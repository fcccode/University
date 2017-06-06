package tesseract.ddnsking.com.lab_6;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.DefaultItemAnimator;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.view.View;
import java.util.ArrayList;
import java.util.List;
import tesseract.ddnsking.com.lab_6.RecyclerItemClickListener.OnItemClickListener;

public class MainActivity extends AppCompatActivity {

  private List<ListItem> mList = new ArrayList<>();
  private RecyclerView recyclerView;
  private Adapter mAdapter;
  private Intent intent;

  @Override
  protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    setContentView(R.layout.activity_main);
    intent = new Intent(this,InfoActivity.class);
    recyclerView = (RecyclerView) findViewById(R.id.recycler_view);
    mAdapter = new Adapter(mList);
    RecyclerView.LayoutManager mLayoutManager = new LinearLayoutManager(getApplicationContext());
    recyclerView.setLayoutManager(mLayoutManager);
    recyclerView.setItemAnimator(new DefaultItemAnimator());
    recyclerView.setAdapter(mAdapter);
    recyclerView.addOnItemTouchListener(new RecyclerItemClickListener(getApplicationContext(),
        recyclerView, new OnItemClickListener() {
      @Override
      public void onItemClick(View view, int position) {
        switch (position){
          case 0:
            intent.putExtra("text","The Game ");
            intent.putExtra("pic_1",R.drawable.pic_1);
            intent.putExtra("pic_2",R.drawable.pic_2);
            intent.putExtra("pic_3",R.drawable.pic_3);
            intent.putExtra("pic_4",R.drawable.pic_4);
            startActivity(intent);
            break;
          case 1:
            intent.putExtra("text","The Flower ");
            intent.putExtra("pic_1",R.drawable.pic_5);
            intent.putExtra("pic_2",R.drawable.pic_6);
            intent.putExtra("pic_3",R.drawable.pic_7);
            intent.putExtra("pic_4",R.drawable.pic_8);
            startActivity(intent);
            break;
          case 2:
            intent.putExtra("text","The Car");
            intent.putExtra("pic_1",R.drawable.pic_9);
            intent.putExtra("pic_2",R.drawable.pic_10);
            intent.putExtra("pic_3",R.drawable.pic_11);
            intent.putExtra("pic_4",R.drawable.pic_12);
            startActivity(intent);
            break;
          case 3:
            intent.putExtra("text","The Actor ");
            intent.putExtra("pic_1",R.drawable.pic_13);
            intent.putExtra("pic_2",R.drawable.pic_14);
            intent.putExtra("pic_3",R.drawable.pic_15);
            intent.putExtra("pic_4",R.drawable.pic_16);
            startActivity(intent);
            break;
          case 4:
            intent.putExtra("text","The House ");
            intent.putExtra("pic_1",R.drawable.pic_17);
            intent.putExtra("pic_2",R.drawable.pic_18);
            intent.putExtra("pic_3",R.drawable.pic_19);
            intent.putExtra("pic_4",R.drawable.pic_20);
            startActivity(intent);
            break;
        }
      }
      @Override
      public void onLongItemClick(View view, int position) { }
    }));
    prepareData();
  }

  private void prepareData() {
    ListItem item = new ListItem(" The Game :", R.drawable.ic_1);
    mList.add(item);
    item = new ListItem("The Flower :", R.drawable.ic_2);
    mList.add(item);
    item = new ListItem("The Car: ", R.drawable.ic_3);
    mList.add(item);
    item = new ListItem("The Actor :", R.drawable.ic_4);
    mList.add(item);
    item = new ListItem("The House  :", R.drawable.ic_5);
    mList.add(item);

    mAdapter.notifyDataSetChanged();
  }
}