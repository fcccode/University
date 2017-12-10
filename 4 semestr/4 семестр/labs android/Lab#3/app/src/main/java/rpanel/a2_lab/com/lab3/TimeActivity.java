package rpanel.a2_lab.com.lab3;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Calendar;

public class TimeActivity extends AppCompatActivity {

  TextView txt;
  DateFormat df;

  @Override
  protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    setContentView(R.layout.activity_time);
    txt = (TextView) findViewById(R.id.textView2);
    df = new SimpleDateFormat("HH:mm:ss");

    Thread t = new Thread() {
      @Override
      public void run() {
        try {
          while (!isInterrupted()) {
            runOnUiThread(new Runnable() {
              @Override
              public void run() {
                txt.setText(df.format(Calendar.getInstance().getTime()));
              }
            });
            Thread.sleep(1000);
          }
        } catch (InterruptedException e) {
        }
      }
    };
    t.start();
  }
}
