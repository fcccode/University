package rpanel.a2_lab.com.lab3;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.widget.TextView;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Calendar;

public class DateActivity extends AppCompatActivity {

  TextView txt;

  @Override
  protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    setContentView(R.layout.activity_date);
    txt = (TextView) findViewById(R.id.textView);
    DateFormat df = new SimpleDateFormat("dd.MM.yyyy");
    txt.setText(df.format(Calendar.getInstance().getTime()));

  }
}
