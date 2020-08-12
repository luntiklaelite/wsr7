package com.example.wsr7;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.app.DatePickerDialog;
import android.app.Dialog;
import android.content.Context;
import android.content.DialogInterface;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.JsonReader;
import android.view.ContextMenu;
import android.view.LayoutInflater;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Spinner;
import android.widget.Switch;
import android.widget.TextView;

import com.example.wsr7.entities.EventAgent;

import org.json.JSONException;
import org.json.JSONObject;
import org.w3c.dom.Text;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    Context context = this;
    ListView lw;
    int NowAgentId = 7;
    EditText date_search;
    long fromDate, toDate;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Button but_add_event = findViewById(R.id.button_add_event);
        but_add_event.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Dialog dialog = new Dialog(context);
                dialog.setContentView(R.layout.addevent);
                final Spinner spinner = dialog.findViewById(R.id.spinner_types);
                spinner.setAdapter(new ArrayAdapter<EventAgent.typeEvent>(context, R.layout.support_simple_spinner_dropdown_item, EventAgent.typeEvent.getAllTypes()));
                Button add = dialog.findViewById(R.id.addeventlayout_addbutt);
                final EditText duration = dialog.findViewById(R.id.edit_duration);
                final EditText comment = dialog.findViewById(R.id.edit_comment);
                final EditText date = dialog.findViewById(R.id.edit_date);
                date.setFocusable(false);
               // int dateint;
                final long[] dateint = new long[1];
                date.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        DatePickerDialog datedialog = new DatePickerDialog(context, new DatePickerDialog.OnDateSetListener() {
                            @Override
                            public void onDateSet(DatePicker datePicker, int y, int m, int d) {
                                Calendar calendar = Calendar.getInstance();
                                calendar.set(y,m,d);
                                SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd");
                                date.setText(format.format(calendar.getTime()));
                                dateint[0] = calendar.getTimeInMillis()/1000;
                            }
                        }, 2020, 1, 1);
                        datedialog.show();
                    }
                });;
                add.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        EventAgent eventAgent = new EventAgent();
                        eventAgent.setComment( comment.getText().toString());
                        eventAgent.setEvent_type((EventAgent.typeEvent) spinner.getSelectedItem());
                        eventAgent.setDuration(Integer.parseInt(duration.getText().toString()));
                        eventAgent.setAgent_id(7);

                        eventAgent.setDatetime((int) dateint[0]);
                        new addEvent().execute(eventAgent);
                    }
                });
                dialog.show();
            }
        });

        date_search = findViewById(R.id.edit_date_search);
        date_search.setFocusable(false);
        Date curDateStart = Calendar.getInstance().getTime();
        curDateStart.setHours(0);
        curDateStart.setMinutes(0);
        curDateStart.setSeconds(0);
        fromDate = curDateStart.getTime()/1000;
        Calendar cal = Calendar.getInstance();
        cal.add(Calendar.DATE, 1);
        curDateStart = cal.getTime();
        curDateStart.setHours(0);
        curDateStart.setMinutes(0);
        curDateStart.setSeconds(0);
        toDate = curDateStart.getTime()/1000;
        date_search.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                DatePickerDialog datedialog = new DatePickerDialog(context, new DatePickerDialog.OnDateSetListener() {
                    @Override
                    public void onDateSet(DatePicker datePicker, int y, int m, int d) {
                        Calendar calendar = Calendar.getInstance();
                        calendar.set(y,m,d,0,0,0);
                        SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd");
                        date_search.setText(format.format(calendar.getTime()));
                        fromDate = calendar.getTimeInMillis()/1000;
                        calendar.add(Calendar.DATE, 1);
                        toDate = calendar.getTimeInMillis()/1000;
                        new getEventsList().execute();
                    }
                }, 2020, 1, 1);
                datedialog.show();
            }
        });
        lw = findViewById(R.id.listboxevents);
        new getEventsList().execute();
        registerForContextMenu(lw);
    }

    @Override
    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo) {
        super.onCreateContextMenu(menu, v, menuInfo);
        getMenuInflater().inflate(R.menu.menuevent, menu);
    }

    @Override
    public boolean onContextItemSelected(@NonNull MenuItem item) {
        AdapterView.AdapterContextMenuInfo menuInfo = (AdapterView.AdapterContextMenuInfo) item.getMenuInfo();
        final EventAgent event = (EventAgent) menuInfo.targetView.getTag();
        switch(item.getItemId()) {
            case R.id.menu_event_dell:
                AlertDialog.Builder builder = new AlertDialog.Builder(context);
                builder.setMessage("Вы действительно хотите удалить это событие?");
                builder.setPositiveButton("Да", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        new dellEvent().execute(event.getUuid());
                    }
                });
                builder.setNegativeButton("Нет", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {

                    }
                });
                builder.create().show();
            default:
                return super.onContextItemSelected(item);
        }
    }

    public static String getResponseString(HttpURLConnection conn, String toCheck) throws JSONException, IOException {
        InputStream stream;
        String toGet;
        if(conn.getResponseCode() >= 200 && conn.getResponseCode() < 300) {
            stream = conn.getInputStream();
            toGet = toCheck;
        }
        else {
            stream = conn.getErrorStream();
            toGet = "error";
        }
        BufferedReader r = new BufferedReader(new InputStreamReader((stream)));
        StringBuilder b = new StringBuilder();
        for(String s; (s = r.readLine()) != null;) {
            b.append(s).append("\n");
        }
        JSONObject obj = new JSONObject(b.toString());
        return obj.getString(toGet);
    }

    //ПРОСТОЙ ДИАЛОГ С "OK"
    public class simpleDialog {
        public simpleDialog(String message) {
            AlertDialog.Builder dialog = new AlertDialog.Builder(context);
            dialog.setMessage(message);
            dialog.setPositiveButton("OK", new DialogInterface.OnClickListener() {
                @Override
                public void onClick(DialogInterface dialogInterface, int i) {

                }
            });
            dialog.create().show();
        }
    }
    //

    //АДАПТЕР ДЛЯ СОБЫТИЯ
    public class eventAdapter extends ArrayAdapter<EventAgent> {

        public eventAdapter(@NonNull Context context, int resource, @NonNull List<EventAgent> objects) {
            super(context, resource, objects);
        }

        @NonNull
        @Override
        public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {
            EventAgent event = getItem(position);
            if(convertView == null)
                convertView = LayoutInflater.from(context).inflate(R.layout.eventlayoutadapter, null);
            convertView.setTag(event);
            TextView uuid = convertView.findViewById(R.id.eventId);
            TextView datetime = convertView.findViewById(R.id.event_datetime);
            TextView duration = convertView.findViewById(R.id.event_duration);
            TextView type = convertView.findViewById(R.id.event_type);
            TextView comment = convertView.findViewById(R.id.event_comment);
            uuid.setText("UUID: " + event.getUuid());
            datetime.setText("Дата: " + event.getDatetime());
            duration.setText("Длительность(сек): " + event.getDuration());
            type.setText("Тип: " + event.getEventName());
            comment.setText("Комментарий: " + event.getComment());
            return convertView;
        }
    }
    //

    //ASYNC КЛАССЫ
    public class getEventsList extends AsyncTask<String, String, ArrayList<EventAgent>> {

        @Override
        protected ArrayList<EventAgent> doInBackground(String... strings) {
            try {
                HttpURLConnection conn = EventAgent.getConnection("http://188.120.248.48:10080/events?agent_id=" + NowAgentId + "&from=" + fromDate + "&to=" + toDate, "GET");
                JsonReader reader = new JsonReader(new InputStreamReader(conn.getInputStream()));;
                ArrayList<EventAgent> events = new ArrayList<EventAgent>();
                reader.beginArray();
                while(reader.hasNext()) {
                    events.add(EventAgent.getEventFromReader(reader));
                }
                reader.endArray();
                return events;
            } catch (IOException e) {
                e.printStackTrace();

            }
            return new ArrayList<EventAgent>();
        }

        @Override
        protected void onPostExecute(ArrayList<EventAgent> eventAgents) {
            super.onPostExecute(eventAgents);
            lw.setAdapter(new eventAdapter(context, R.layout.eventlayoutadapter, eventAgents));
        }
    }

    public class addEvent extends AsyncTask<EventAgent, String, String> {

        @Override
        protected String doInBackground(EventAgent... events) {
            try {
                HttpURLConnection conn = EventAgent.getConnection("http://188.120.248.48:10080/event", "POST");
                EventAgent agent = events[0];
                conn.getOutputStream().write(("agent_id="+ agent.getAgent_id() + "&datetime=" + agent.getDatetime() + "&type=" + agent.getEvent_type().getName() + "&duration=" + agent.getDuration()+ "&comment=" + agent.getComment()).getBytes());
                int code = conn.getResponseCode();
                return getResponseString(conn, "uuid");
            } catch (IOException | JSONException e) {
                e.printStackTrace();
            }
            return "error";
        }

        @Override
        protected void onPostExecute(String s) {
            super.onPostExecute(s);
            new simpleDialog(s);
            new getEventsList().execute();
        }
    }

    public class dellEvent extends AsyncTask<String, String, String> {

        @Override
        protected String doInBackground(String... strings) {
            try {
                HttpURLConnection conn = EventAgent.getConnection("http://188.120.248.48:10080/event", "DELETE");
                conn.getOutputStream().write(("agent_id=7&event_uuid="+strings[0]).getBytes());
                return "Удалено";
            } catch (IOException e) {
                e.printStackTrace();
            }
            return "error";
        }

        @Override
        protected void onPostExecute(String s) {
            super.onPostExecute(s);
            new simpleDialog(s);
            new getEventsList().execute();
        }
    }
    //
}