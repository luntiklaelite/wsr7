<?php
    header('Content-Type: application/json');
    $valid_event_types = ["meeting", "presentation", "phone_call"];

    function error($code, $message) {
        http_response_code($code);
        echo json_encode(["error" => $message]);
        die();
    }

    function data_dir() {
        return getcwd()."/events";
    }

    function agent_datafile($agent_id) {
        return data_dir()."/$agent_id.json";
    }

    function read_datafile($agent_id) {
        if(!file_exists(agent_datafile($agent_id))) {
            return [];
        }

        return json_decode(file_get_contents(agent_datafile($agent_id)), true);
    }

    function write_datafile($agent_id, $events) {
        if(!file_exists(data_dir()))
            mkdir(data_dir(), 0777);

        file_put_contents(agent_datafile($agent_id), json_encode($events));
    }

    function uuid_v4() {
        return sprintf( '%04x%04x-%04x-%04x-%04x-%04x%04x%04x',
            mt_rand( 0, 0xffff ), mt_rand( 0, 0xffff ),
            mt_rand( 0, 0xffff ),
            mt_rand( 0, 0x0fff ) | 0x4000,
            mt_rand( 0, 0x3fff ) | 0x8000,
            mt_rand( 0, 0xffff ), mt_rand( 0, 0xffff ), mt_rand( 0, 0xffff )
        );
    }

    function create_event($agent_id, $datetime, $duration, $type, $comment) {
        $event_uuid = uuid_v4();
        $event = [
            "uuid" => $event_uuid,
            "agent_id" => $agent_id,
            "datetime" => $datetime,
            "duration" => $duration,
            "type" =>  $type,
            "comment" => $comment
        ];

        $events = read_datafile($agent_id);
        $events[$event_uuid] = $event;
        write_datafile($agent_id, $events);
        return $event;
    }

    function cancel_event($agent_id, $event_uuid) {
        $events = read_datafile($agent_id);

        if (!isset($events[$event_uuid])) {
            error(404, "event $event_uuid not found");
        }

        unset($events[$event_uuid]);
        write_datafile($agent_id, $events);
    }

    function get_events($agent_id, $from, $to) {
        $events = read_datafile($agent_id);
        return array_filter($events, function($event) use ($from, $to) {
            return $from <= $event["datetime"] && $event["datetime"] <= $to;
        });
    }

    $request_uri = (isset($_SERVER['HTTPS']) && $_SERVER['HTTPS'] === 'on' ? "https" : "http") . "://$_SERVER[HTTP_HOST]$_SERVER[REQUEST_URI]";
    $request_path = parse_url($request_uri, PHP_URL_PATH);
    $request_method = $_SERVER["REQUEST_METHOD"];

    if ($request_path == "/event" && $request_method == "POST") {
        $options = ["options" => ["min_range" => 0]];
        $agent_id = filter_input(INPUT_POST, "agent_id", FILTER_VALIDATE_INT, $options);
        $datetime = filter_input(INPUT_POST, "datetime", FILTER_VALIDATE_INT, $options);
        $duration = filter_input(INPUT_POST, "duration", FILTER_VALIDATE_INT, $options);
        $type = filter_input(INPUT_POST, "type");
        $comment = filter_input(INPUT_POST, "comment");

        if (!$agent_id) {
            error(400, "empty or invalid agent_id");
        }

        if (!$datetime) {
            error(400, "empty or invalid datetime");
        }

        if (array_search($type, $valid_event_types) === false) {
            error(400, "empty or invalid event type, allowed types: ".json_encode($valid_event_types));
        }

        echo json_encode(create_event($agent_id, $datetime, $duration, $type, $comment));
    } else if ($request_path == "/event" && $request_method == "DELETE") {
        parse_str(file_get_contents("php://input"), $args);
        $agent_id = $args["agent_id"];
        $event_uuid = $args["event_uuid"];

        if (!$agent_id) {
            error(400, "empty or invalid agent_id");
        }

        if (empty($event_uuid)) {
            error(400, "empty or invalid event_uuid");
        }

        cancel_event($agent_id, $event_uuid);
    } else if ($request_path == "/events" && $request_method == "GET") {
        $options = ["options" => ["min_range" => 0]];
        $agent_id = filter_input(INPUT_GET, "agent_id", FILTER_VALIDATE_INT, $options);
        $from = filter_input(INPUT_GET, "from", FILTER_VALIDATE_INT, $options);
        $to = filter_input(INPUT_GET, "to", FILTER_VALIDATE_INT, $options);

        if (!$agent_id) {
            error(400, "empty or invalid agent_id");
        }

        if (!$from) {
            error(400, "empty or invalid from");
        }

        if (!$to) {
            error(400, "empty or invalid to");
        }

        echo json_encode(array_values(get_events($agent_id, $from, $to)));
    } else {
        error(404, "not found");
    }
