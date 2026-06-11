# Data Structures Project: List, Stack, Queue and Priority Queue in C#

## English

This project is a C# console application that demonstrates how fundamental data structures can be used to process real data and solve queue-based problems.

The project has two main parts. The first part reads fish species data from an external text file, converts the raw text into structured objects, and processes the data using different collection structures. The second part simulates a market checkout queue and compares how FIFO queue logic and priority-based queue logic affect the average completion time.

The project was built to understand how data structures behave in practical scenarios, not only as isolated theoretical concepts. It shows how the choice of a data structure can change the order of processing, the way data is organized, and the final result of a problem.

---

## Project Overview

### 1. Fish Species Data Processing

In this section, the application reads fish data from a text file and parses it into structured fish objects.

Each fish object contains information such as:

* Fish name
* Alternative name
* Size information
* Description
* Habitat / sea information

After the data is parsed, it is stored and processed using different data structures such as generic lists, grouped lists, stacks, and queues.

This part of the project focuses on transforming raw text data into usable objects and observing how different data structures process the same dataset in different orders.

---

### 2. Market Checkout Queue Simulation

The second part of the project simulates a market checkout scenario.

Each customer is represented by the number of products they have. The application calculates the average completion time using two different queue strategies:

* Standard FIFO Queue
* Priority Queue based on product count

The FIFO queue processes customers in the order they arrive. The priority-based queue gives priority to customers with fewer products. This comparison shows how queue strategy directly affects waiting time and average completion time.

---

## Features

* Reads fish species data from an external text file
* Parses raw text into structured object fields
* Represents fish records using a custom class
* Stores and processes data using generic lists
* Groups records using list-based structures
* Demonstrates LIFO behavior with stack
* Demonstrates FIFO behavior with queue
* Simulates priority queue behavior using sorted data
* Calculates average checkout completion time
* Compares FIFO queue and priority-based queue results

---

## Data Structures Used

* Generic List
* List of Lists
* Stack
* Queue
* Priority Queue logic
* Custom class-based object representation

---

## Technologies Used

* C#
* .NET Framework 4.7.2
* Visual Studio 2022
* Object-Oriented Programming
* File I/O
* Console Application Development

---

## What I Implemented and Learned

Through this project, I practiced how to use core data structures in C# with real input data and simulation-based problems.

In the fish data processing part, I worked on reading external files, parsing unstructured text, creating objects from raw data, and organizing those objects with collection structures. This helped me understand how data preparation and object modeling are handled before applying algorithms or data structure operations.

In the queue simulation part, I compared two different processing strategies. By calculating average completion times, I observed that the selected queue structure can directly affect the efficiency of a system.

Main topics I practiced:

* Creating custom classes
* Reading and parsing external files
* Using generic collections in C#
* Understanding Stack and LIFO behavior
* Understanding Queue and FIFO behavior
* Simulating priority-based processing
* Comparing algorithmic results with calculated values
* Applying object-oriented programming principles

---

# Veri Yapıları Projesi: C# ile List, Stack, Queue ve Priority Queue

## Türkçe

Bu proje, temel veri yapılarının gerçek veri işleme ve kuyruk tabanlı problem çözme senaryolarında nasıl kullanılabileceğini gösteren bir C# konsol uygulamasıdır.

Proje iki ana bölümden oluşmaktadır. İlk bölümde, harici bir metin dosyasından balık türlerine ait veriler okunur, ham metin verisi yapılandırılmış nesnelere dönüştürülür ve farklı collection yapıları üzerinde işlenir. İkinci bölümde ise bir market kasa kuyruğu simüle edilir ve FIFO queue mantığı ile öncelik tabanlı queue mantığının ortalama tamamlanma süresine etkisi karşılaştırılır.

Bu proje, veri yapılarını yalnızca teorik olarak değil, pratik bir problem üzerinde kullanarak anlamak amacıyla geliştirilmiştir. Kullanılan veri yapısının işlem sırasını, verinin organize edilme şeklini ve problemin sonucunu nasıl değiştirebildiğini göstermektedir.

---

## Proje Özeti

### 1. Balık Türleri Veri İşleme

Bu bölümde uygulama, bir metin dosyasından balık verilerini okur ve bu verileri yapılandırılmış balık nesnelerine dönüştürür.

Her balık nesnesi şu bilgileri içerir:

* Balık adı
* Diğer adı
* Boyut bilgisi
* Açıklama
* Yaşadığı deniz / ortam bilgisi

Veriler ayrıştırıldıktan sonra generic list, liste grupları, stack ve queue gibi farklı veri yapıları kullanılarak işlenir.

Bu bölümde amaç, ham metin verisinin kullanılabilir nesnelere nasıl dönüştürüleceğini ve aynı veri setinin farklı veri yapılarıyla farklı işlem sıralarında nasıl ele alınabileceğini göstermektir.

---

### 2. Market Kasa Kuyruğu Simülasyonu

Projenin ikinci bölümünde bir market kasa kuyruğu simüle edilir.

Her müşteri, sahip olduğu ürün sayısı ile temsil edilir. Uygulama iki farklı kuyruk stratejisi için ortalama tamamlanma süresini hesaplar:

* Standart FIFO Queue
* Ürün sayısına göre öncelikli kuyruk

FIFO queue müşterileri geliş sırasına göre işler. Öncelik tabanlı queue ise daha az ürüne sahip müşterilere öncelik verir. Bu karşılaştırma, kuyruk stratejisinin bekleme süresi ve ortalama tamamlanma süresi üzerinde doğrudan etkili olabileceğini gösterir.

---

## Özellikler

* Harici metin dosyasından balık türü verilerini okuma
* Ham metin verisini anlamlı alanlara ayrıştırma
* Balık kayıtlarını özel bir sınıf ile temsil etme
* Generic list kullanarak veri saklama ve işleme
* Liste tabanlı gruplama işlemleri yapma
* Stack ile LIFO davranışını gösterme
* Queue ile FIFO davranışını gösterme
* Sıralama kullanarak priority queue mantığını simüle etme
* Ortalama kasa işlem tamamlanma süresini hesaplama
* FIFO queue ve priority queue sonuçlarını karşılaştırma

---

## Kullanılan Veri Yapıları

* Generic List
* List of Lists
* Stack
* Queue
* Priority Queue mantığı
* Sınıf tabanlı nesne temsili

---

## Kullanılan Teknolojiler

* C#
* .NET Framework 4.7.2
* Visual Studio 2022
* Nesne Yönelimli Programlama
* Dosya Okuma/Yazma İşlemleri
* Konsol Uygulaması Geliştirme

---

## Bu Projede Ne Uyguladım ve Ne Öğrendim?

Bu projede, C# üzerinde temel veri yapılarını gerçek veri girişi ve simülasyon tabanlı problemlerle kullanmayı uyguladım.

Balık verisi işleme bölümünde harici dosyadan veri okuma, düzensiz metin verisini ayrıştırma, ham veriden nesne oluşturma ve bu nesneleri collection yapılarıyla organize etme konularında çalıştım. Bu kısım, algoritma veya veri yapısı uygulamadan önce verinin nasıl hazırlanması ve modellenmesi gerektiğini anlamamı sağladı.

Kuyruk simülasyonu bölümünde ise iki farklı işlem stratejisini karşılaştırdım. Ortalama tamamlanma sürelerini hesaplayarak, seçilen kuyruk yapısının sistem verimliliğini doğrudan etkileyebileceğini gördüm.

Bu projede pratik yaptığım ana konular:

* Özel sınıf oluşturma
* Harici dosyadan veri okuma ve ayrıştırma
* C# generic collection yapılarını kullanma
* Stack ve LIFO mantığını anlama
* Queue ve FIFO mantığını anlama
* Öncelik tabanlı işlem sırası simüle etme
* Hesaplanan sonuçlar üzerinden farklı yaklaşımları karşılaştırma
* Nesne yönelimli programlama prensiplerini uygulama
