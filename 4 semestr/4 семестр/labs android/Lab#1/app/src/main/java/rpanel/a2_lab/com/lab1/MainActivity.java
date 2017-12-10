package rpanel.a2_lab.com.lab1;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {

  Button btn1;
  Button btn2;
  EditText edt;

  @Override
  protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    setContentView(R.layout.activity_main);
    btn1 = (Button) findViewById(R.id.button2);
    btn2 = (Button) findViewById(R.id.button3);
    edt = (EditText) findViewById(R.id.editText);

    btn2.setOnClickListener(new OnClickListener() {
      @Override
      public void onClick(View view) {
        edt.setText("HelloWorld! Левицький А.О.");
      }
    });

    btn1.setOnClickListener(new OnClickListener() {
      @Override
      public void onClick(View view) {
        finish();
      }
    });
  }
}
