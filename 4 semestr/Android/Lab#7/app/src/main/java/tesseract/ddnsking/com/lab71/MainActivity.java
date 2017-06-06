package tesseract.ddnsking.com.lab71;

import android.content.Context;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.support.v4.view.ViewPager;
import android.support.v4.view.ViewPager.OnPageChangeListener;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.HorizontalScrollView;
import android.widget.TabHost;
import android.widget.TabHost.OnTabChangeListener;
import android.widget.TabHost.TabContentFactory;
import java.util.List;
import java.util.Vector;

public class MainActivity extends AppCompatActivity implements
    OnTabChangeListener, OnPageChangeListener {

  private TabHost tabHost;
  private ViewPager viewPager;
  private MyFragmentPagerAdapter myViewPagerAdapter;
  int i = 0;

  class FakeContent implements TabContentFactory {
    private final Context mContext;

    public FakeContent(Context context) {
      mContext = context;
    }

    @Override
    public View createTabContent(String tag) {
      View v = new View(mContext);
      v.setMinimumHeight(0);
      v.setMinimumWidth(0);
      return v;
    }
  }

  @Override
  protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    setContentView(R.layout.activity_main);
    i++;
    this.initializeTabHost(savedInstanceState);
    this.initializeViewPager();
  }

  private void initializeViewPager() {
    List<Fragment> fragments = new Vector<Fragment>();
    fragments.add(new TabFragment(
            "Игры :",
            R.drawable.pic_1,
            R.drawable.pic_2,
            R.drawable.pic_3,
            R.drawable.pic_4));
    fragments.add(new TabFragment(
            "Цветы :",
            R.drawable.pic_1,
            R.drawable.pic_2,
            R.drawable.pic_3,
            R.drawable.pic_4));
    fragments.add(new TabFragment(
            "Машины :",
            R.drawable.pic_1,
            R.drawable.pic_2,
            R.drawable.pic_3,
            R.drawable.pic_4));
    fragments.add(new TabFragment(
            "Актеры :",
            R.drawable.pic_1,
            R.drawable.pic_2,
            R.drawable.pic_3,
            R.drawable.pic_4));
    fragments.add(new TabFragment(
            "Дома :",
            R.drawable.pic_1,
            R.drawable.pic_2,
            R.drawable.pic_3,
            R.drawable.pic_4));

    this.myViewPagerAdapter = new MyFragmentPagerAdapter(
        getSupportFragmentManager(), fragments);
    this.viewPager = (ViewPager) super.findViewById(R.id.viewPager);
    this.viewPager.setAdapter(this.myViewPagerAdapter);
    this.viewPager.setOnPageChangeListener(this);
    onRestart();
  }

  private void initializeTabHost(Bundle args) {

    tabHost = (TabHost) findViewById(android.R.id.tabhost);
    tabHost.setup();

    for (int i = 1; i <= 10; i++) {

      TabHost.TabSpec tabSpec;
      tabSpec = tabHost.newTabSpec("Tab " + i);
      tabSpec.setIndicator("Tab " + i);
      tabSpec.setContent(new FakeContent(this));
      tabHost.addTab(tabSpec);
    }
    tabHost.setOnTabChangedListener(this);
  }

  @Override
  public void onTabChanged(String tabId) {
    int pos = this.tabHost.getCurrentTab();
    this.viewPager.setCurrentItem(pos);

    HorizontalScrollView hScrollView = (HorizontalScrollView) findViewById(R.id.hScrollView);
    View tabView = tabHost.getCurrentTabView();
    int scrollPos = tabView.getLeft()
        - (hScrollView.getWidth() - tabView.getWidth()) / 2;
    hScrollView.smoothScrollTo(scrollPos, 0);

  }

  @Override
  public void onPageScrollStateChanged(int arg0) {
  }

  @Override
  public void onPageScrolled(int arg0, float arg1, int arg2) {
  }

  @Override
  public void onPageSelected(int position) {
    this.tabHost.setCurrentTab(position);
  }
}
