package com.example.wsr7.entities;

import android.net.Uri;
import android.util.JsonReader;

import androidx.annotation.NonNull;

import java.io.IOException;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.ArrayList;

public class EventAgent {
    public enum typeEvent {
        meeting,
        presentation,
        phone_call;

        @NonNull
        @Override
        public String toString() {
            switch(this) {
                case meeting:
                    return "Встреча с клиентом";
                case presentation:
                    return "Показ";
                case phone_call:
                    return "Запланированный звонок";
                default:
                    return "untype";
            }
        }

        public String getName() {
            switch(this) {
                case meeting:
                    return "meeting";
                case presentation:
                    return "presentation";
                case phone_call:
                    return "phone_call";
                default:
                    return "untype";
            }
        }

        public static ArrayList<typeEvent> getAllTypes() {
            ArrayList<typeEvent> types = new ArrayList<typeEvent>();
            types.add(meeting);
            types.add(phone_call);
            types.add(presentation);
            return types;
        }
    }

    String uuid;
    int agent_id = 7;
    int datetime;
    int duration;
    typeEvent event_type;
    String comment;

    public EventAgent() {    }

    public EventAgent(String uuid, int datetime, int duration, typeEvent event_type, String comment) {
        this.agent_id = 7;
        this.comment = comment;
        this.uuid = uuid;
        this.datetime = datetime;
        this.duration = duration;
        this.event_type = event_type;
    }
    //GETTERS
    public int getAgent_id() {
        return agent_id;
    }

    public int getDatetime() {
        return datetime;
    }

    public int getDuration() {
        return duration;
    }

    public String getComment() {
        return comment;
    }

    public String getUuid() {
        return uuid;
    }

    public typeEvent getEvent_type() {
        return event_type;
    }
    public String getEventName() {
        return event_type.toString();
    }

    //SETTERS

    public void setAgent_id(int agent_id) {
        this.agent_id = agent_id;
    }


    public void setComment(String comment) {
        this.comment = comment;
    }

    public void setDuration(int duration) {
        this.duration = duration;
    }

    public void setDatetime(int datetime) {
        this.datetime = datetime;
    }

    public void setEvent_type(typeEvent event_type) {
        this.event_type = event_type;
    }

    public void setEvent_type(String event_type) {
        switch (event_type) {
            case "presentation":
                this.event_type = typeEvent.presentation;
                break;
            case "meeting":
                this.event_type = typeEvent.meeting;
                break;
            case "phone_call":
                this.event_type = typeEvent.phone_call;
                break;
        }
    }

    public void setUuid(String uuid) {
        this.uuid = uuid;
    }
    ///////////////////////////////////////////////////

    public static EventAgent getEventFromReader(JsonReader reader) throws IOException {
        reader.beginObject();
        EventAgent agent = new EventAgent();
        while(reader.hasNext()) {
            switch (reader.nextName()) {
                case "uuid":
                    agent.setUuid(reader.nextString());
                    break;
                case "agent_id":
                    agent.setAgent_id(reader.nextInt());
                    break;
                case "datetime":
                    agent.setDatetime(reader.nextInt());
                    break;
                case "duration":
                    agent.setDuration(reader.nextInt());
                    break;
                case "type":
                    agent.setEvent_type(reader.nextString());
                    break;
                case "comment":
                    agent.setComment(reader.nextString());
                    break;
                default:
                    reader.skipValue();
            }
        }
        reader.endObject();
        return agent;
    }


    //функции к хосту
    public static HttpURLConnection getConnection(String url, String method) throws IOException {
        HttpURLConnection conn = (HttpURLConnection) new URL(url).openConnection();
        conn.setRequestMethod(method);
        return conn;
    }



    //

}
