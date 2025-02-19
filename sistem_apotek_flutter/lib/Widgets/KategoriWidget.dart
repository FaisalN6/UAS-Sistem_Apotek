import 'package:flutter/material.dart';

class KategoriWidget extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      scrollDirection: Axis.horizontal,
      child: Padding(
        padding: EdgeInsets.symmetric(vertical: 15, horizontal: 5),
        child: Row(
          children: [
            // Item pertama - Sirup
            buildCategoryItem(
              context,
              "Sirup",
              "images/sirup.jpg",
              '/itemPageSirup', // Rute navigasi untuk Sirup
            ),
            // Item kedua - Kapsul
            buildCategoryItem(
              context,
              "Kapsul",
              "images/kapsul.jpg",
              '/itemPageKapsul', // Rute navigasi untuk Kapsul
            ),
            // Item ketiga - Tablet
            buildCategoryItem(
              context,
              "Tablet",
              "images/tablet.jpg",
              '/itemPageTablet', // Rute navigasi untuk Tablet
            ),
            // Item keempat - Salep
            buildCategoryItem(
              context,
              "Salep",
              "images/salep.png",
              '/itemPageSalep', // Rute navigasi untuk Salep
            ),
            // Item kelima - Vitamin
            buildCategoryItem(
              context,
              "Vitamin",
              "images/vitamin.jpg",
              '/itemPageVitamin', // Rute navigasi untuk Vitamin
            ),
          ],
        ),
      ),
    );
  }

  Widget buildCategoryItem(BuildContext context, String title, String imagePath, String routeName) {
    return InkWell(
      onTap: () {
        // Aksi ketika item diklik
        print("$title diklik");
        Navigator.pushNamed(context, routeName); // Navigasi ke halaman terkait
      },
      child: Padding(
        padding: EdgeInsets.symmetric(horizontal: 10),
        child: Column(
          children: [
            Container(
              padding: EdgeInsets.all(8),
              decoration: BoxDecoration(
                color: Colors.white,
                borderRadius: BorderRadius.circular(10),
                boxShadow: [
                  BoxShadow(
                    color: Colors.grey.withOpacity(0.5),
                    spreadRadius: 2,
                    blurRadius: 10,
                    offset: Offset(0, 3),
                  ),
                ],
              ),
              child: Image.asset(
                imagePath,
                width: 50,
                height: 50,
              ),
            ),
            SizedBox(height: 5), // Spacer
            Text(
              title,
              style: TextStyle(fontSize: 12, fontWeight: FontWeight.bold),
            ),
          ],
        ),
      ),
    );
  }
}
