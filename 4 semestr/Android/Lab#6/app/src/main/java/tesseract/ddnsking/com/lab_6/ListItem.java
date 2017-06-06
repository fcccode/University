package tesseract.ddnsking.com.lab_6;

public class ListItem {
  private String title;
  private int img;

  public ListItem(String title, int image) {
    this.title = title;
    this.img = image;
  }

  public String getTitle() {
    return title;
  }

  public int getImageId() {
    return img;
  }
}
