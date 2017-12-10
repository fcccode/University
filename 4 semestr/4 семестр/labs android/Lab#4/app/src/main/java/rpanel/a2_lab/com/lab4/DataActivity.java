package rpanel.a2_lab.com.lab4;

import android.content.Intent;
import android.content.SharedPreferences;
import android.content.SharedPreferences.Editor;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class DataActivity extends AppCompatActivity {

  EditText edt;
  Button btn;
  SharedPreferences sPref;

  @Override
  protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    setContentView(R.layout.activity_data);
    btn = (Button) findViewById(R.id.button3);
    edt = (EditText) findViewById(R.id.editText);
    btn.setOnClickListener(new OnClickListener() {
      @Override
      public void onClick(View view) {
        if(!edt.getText().toString().equals("")){
          sPref = getSharedPreferences("myPref",MODE_PRIVATE);
          Editor ed = sPref.edit();
          ed.putString("jsabg3huiHHS4352bgkjsdug364HASKjgnjds1", edt.getText().toString());
          ed.apply();
          startActivity(new Intent(getApplicationContext(), MainActivity.class));
          finish();
        }else {
          Toast.makeText(DataActivity.this, "Поле не може бути пустим", Toast.LENGTH_SHORT).show();
        }
      }
    });
  }

}
