# Linked List Partition Probleminin Çözüm Yöntemleri

## 1. İki Geçici Liste Kullanmak
- **Metod**: Bu yöntemde, girdi listesi taranır ve 'x' değerinden küçük olan elemanlar bir liste, büyük veya eşit olanlar başka bir liste içerisine eklenir. Sonrasında bu iki liste birleştirilir.
- **Zorluk**: 4/10
- **Zaman Karmaşıklığı**: O(n)
- **Alan Karmaşıklığı**: O(n)

## 2. Yerinde Düzenleme
- **Metod**: Bu yöntemde, liste üzerinde yerinde düzenlemeler yapılır. 'x' değerinden küçük elemanlar liste başına, büyük veya eşit olanlar ise liste sonuna yerleştirilir.
- **Zorluk**: 6/10
- **Zaman Karmaşıklığı**: O(n)
- **Alan Karmaşıklığı**: O(1)

## 3. QuickSort Benzeri Bölme
- **Metod**: Bu yöntem, QuickSort algoritmasının bölme işlemine benzer. Liste boyunca ilerlerken, 'x' değerinden küçük elemanlar sol tarafa, büyük veya eşit olanlar sağ tarafa alınır.
- **Zorluk**: 7/10
- **Zaman Karmaşıklığı**: O(n)
- **Alan Karmaşıklığı**: O(log n) (ortalama, yığın boyutu için)

# Her Yöntemin Uygulanması

## İki Geçici Liste Kullanmak
- Listeyi tarayın.
- Her eleman için, değeri 'x'ten küçükse birinci geçici listeye, değilse ikinci geçici listeye ekleyin.
- İki listeyi son elemandan birleştirin.

## Yerinde Düzenleme
- İki işaretçi kullanın: biri baştan, diğeri sondan ilerler.
- Başlangıçta küçük elemanları başa, büyük elemanları sona taşıyın.
- İki işaretçi birbirini geçene kadar bu işlemi sürdürün.

## QuickSort Benzeri Bölme
- Bir işaretçi kullanarak listeyi tarayın.
- 'x'ten küçük elemanları bulduğunuzda, bu elemanları listenin sol tarafına taşıyın.
- 'x'ten büyük veya eşit elemanları sağ tarafa taşıyın.

# Algoritmaları Uygularken Dikkat Edilmesi Gerekenler
- Bağlı liste üzerinde işlem yaparken döngüsel referanslardan kaçının.
- Elemanların orijinal sıralamasını korumak önemli olabilir, bu durumda stabil bir yöntem seçin.
- İşaretçileri kullanırken dikkatli olun, null referans hatası almamaya özen gösterin.
- Yerinde düzenleme yaparken, ekstra alan kullanımını minimize edin.
- Karmaşıklık analizlerini dikkate alarak, girdi boyutu ve performans gereksinimlerine uygun yöntemi seçin.
