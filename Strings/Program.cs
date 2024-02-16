
string sentence = "My name is Furkan Demir";

var result1 = sentence.Length;//eleman sayısnın verir

var result2 = sentence.Clone();//klon oluşturur
result2 = "My name is İrem Karaca";

bool result3 = sentence.EndsWith("r");//ne ile bitiyor onun kontrolü

bool result4 = sentence.StartsWith("My");//ne ile başlıyor onun kontrolü

var result5 = sentence.IndexOf("name");//verilen değerin hangi indexte olduğunu söyler
var result6 = sentence.IndexOf(" ");

var result7 = sentence.LastIndexOf("");//IndexOf ile aynı sadece sondan başlar

var result8 = sentence.Insert(0, "Hello, ");// verilen index değerine göre string ifade ekler

var result9 = sentence.Substring(3);//verilen index'e göre elemanı böler

var result10 = sentence.ToLower();//bütün karakterleri küçüğe çevirir
var result11 = sentence.ToUpper();//bütün karakterleri büyüğe çevirir

var result12 = sentence.Replace(" ", "-");//ilk parametre değişecek karakterler sonrakinde hangi değerin verileceğidir

var result13 = sentence.Remove(2);//Verilen index sayısından itibaren sil

Console.WriteLine(result6);


static void Intro()
{
    string city = "Ankara";
    //Console.WriteLine(city[0]);

    foreach (var item in city)
    {
        Console.WriteLine(item);
    }

    string city2 = "İstanbul";

    Console.WriteLine(String.Format("{0} {1}", city, city2));
}