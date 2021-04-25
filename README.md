# Xml ile hava durumu verisi çekme
## Emrehan Baysal 1912901043
![uygulama](https://user-images.githubusercontent.com/81330668/115980793-1cb26f00-a598-11eb-9808-c6c9ab458a57.JPG)
![UYARI](https://user-images.githubusercontent.com/81330668/115981596-939e3680-a59d-11eb-9e7d-9000a331d5de.png)
![UYARI2](https://user-images.githubusercontent.com/81330668/115981613-a7e23380-a59d-11eb-9e53-ea5f0a31c940.png)

### Türkiyenin bütün illerine hava durumunu anlık çekim yapmaktadır. 
https://openweathermap.org'nın XML dosyasından çekmiş olduğum verileri 60 sn'yede verileri 
kontrol ederek yeni değer varsa ekrana bildirim veren bir uygulama yaptım

# openweathermap api kullanımı ;

http://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&units=metric&lang=tr&appid=*****************
---
api kimliği openweathermap'den almanız gerekiyor
//q=istanbul kısmı hangi şehirden veri çekileceğini belirtir
//mode kısmı verilerin json veya xml olarak çekilceğini belirtir
//units kısmı emparial ve metric olarak oluşturulur emparial Fahrenayt (F) verisi kullanır metric ise santigrat (C)
lang kısmında verilerin dilini seçiyoruz

###Örnek api çağrısı 

` current>
<city id="745042" name="İstanbul">
<coord lon="28.9833" lat="41.0351"/>
<country>TR</country>
<timezone>10800</timezone>
<sun rise="2021-04-25T03:10:00" set="2021-04-25T16:53:44"/>
</city>
<temperature value="10.07" min="9" max="11" unit="celsius"/>
<feels_like value="8.99" unit="celsius"/>
<humidity value="71" unit="%"/>
<pressure value="1016" unit="hPa"/>
<wind>
<speed value="7.72" unit="m/s" name="Moderate breeze"/>
<gusts/>
<direction value="40" code="NE" name="NorthEast"/>
</wind>
<clouds value="75" name="parçalı bulutlu"/>
<visibility value="10000"/>
<precipitation mode="no"/>
<weather number="803" value="parçalı bulutlu" icon="04n"/>
<lastupdate value="2021-04-25T17:45:06"/>
</current>`
