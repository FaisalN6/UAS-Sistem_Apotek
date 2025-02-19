import 'package:flutter/material.dart';

class ItemPage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Padding(
        padding: EdgeInsets.only(top: 5),
        child: ListView(
          children: [
            
            Padding(
              padding: EdgeInsets.all(16),
              child: Image.asset(
                "images/bodrex.jpg",
                height: 300,
                width: 190,
              ),
            ),
            Padding(
              padding: EdgeInsets.all(16),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(
                    "Bodrex",
                    style: TextStyle(
                      fontSize: 24,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                  SizedBox(height: 5),
                  Text(
                    "Bodrex adalah obat yang digunakan untuk meredakan sakit kepala, sakit gigi, dan nyeri ringan lainnya. Bodrex mengandung paracetamol yang bekerja dengan menghambat produksi prostaglandin, zat kimia dalam tubuh yang menyebabkan nyeri dan peradangan.",
                    style: TextStyle(fontSize: 16),
                  ),
                  SizedBox(height: 20),
                  Text(
                    "Cara Minum Obat",
                    style: TextStyle(
                      fontSize: 20,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                  SizedBox(height: 5),
                  Text(
                    "1. Dewasa dan anak-anak di atas 12 tahun: 1-2 tablet setiap 4-6 jam sesuai kebutuhan.\n"
                    "2. Jangan melebihi 8 tablet dalam 24 jam.\n"
                    "3. Anak-anak di bawah 12 tahun: Konsultasikan dengan dokter sebelum penggunaan.\n"
                    "4. Minum obat setelah makan untuk mengurangi risiko iritasi lambung.\n"
                    "5. Jangan menggunakan Bodrex lebih dari 10 hari berturut-turut tanpa anjuran dokter.",
                    style: TextStyle(fontSize: 16),
                  ),
                ],
              ),
            ),
            // Add more widgets here if needed
          ],
        ),
      ),
    );
  }
}

