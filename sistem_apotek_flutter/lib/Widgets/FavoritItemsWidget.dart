import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;

class FavoritItemsWidget extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      scrollDirection: Axis.horizontal,
      child: Padding(
        padding: EdgeInsets.symmetric(vertical: 15, horizontal: 5),
        child: Row(
          children: [
            buildFavoriteItem(
              context,
              imagePath: "images/bodrex.jpg",
              itemName: "Bodrex",
              itemDescription: "Obat Sakit Kepala",
            ),
            buildFavoriteItem(
              context,
              imagePath: "images/paratusin.jpg",
              itemName: "Paratusin",
              itemDescription: "Flu dan sakit kepala",
            ),
            buildFavoriteItem(
              context,
              imagePath: "images/diapet.jpg",
              itemName: "Diapet",
              itemDescription: "Kapsul Untuk mencret",
            ),
            buildFavoriteItem(
              context,
              imagePath: "images/bodrex.jpg",
              itemName: "Bodrex",
              itemDescription: "Obat Sakit Kepala",
            ),
          ],
        ),
      ),
    );
  }

  Widget buildFavoriteItem(
    BuildContext context, {
    required String imagePath,
    required String itemName,
    required String itemDescription,
  }) {
    return Padding(
      padding: EdgeInsets.symmetric(horizontal: 7),
      child: FutureBuilder<Map<String, dynamic>>(
        future: fetchStock(itemName),
        builder: (context, AsyncSnapshot<Map<String, dynamic>> snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return buildItemLoading(imagePath, itemName, itemDescription);
          } else if (snapshot.hasError) {
            return buildItemError(snapshot.error.toString());
          } else if (!snapshot.hasData) {
            return buildItemError('No data available');
          } else {
            int stock = snapshot.data!['stock'] ?? 0;
            //String kdObat = snapshot.data!['kd_obat'] ?? '';

            return GestureDetector(
              onTap: () {
                changeStock(context, itemName, stock);
              },
              child: Container(
                width: 170,
                height: 260,
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
                child: SingleChildScrollView(
                  child: Column(
                    mainAxisAlignment: MainAxisAlignment.center,
                    crossAxisAlignment: CrossAxisAlignment.center,
                    children: [
                      Padding(
                        padding: EdgeInsets.symmetric(horizontal: 10),
                        child: Image.asset(
                          imagePath,
                          width: 150,
                          height: 130,
                        ),
                      ),
                      SizedBox(height: 10),
                      Text(
                        itemName,
                        textAlign: TextAlign.center,
                        style: TextStyle(
                          fontSize: 20,
                          fontWeight: FontWeight.bold,
                        ),
                      ),
                      SizedBox(height: 4),
                      Text(
                        itemDescription,
                        textAlign: TextAlign.center,
                        style: TextStyle(
                          fontSize: 15,
                        ),
                      ),
                     // SizedBox(height: 12),
                      //Text(
                       // "Kode Obat: $kdObat", // Displaying kd_obat above stock
                       // textAlign: TextAlign.center,
                        //style: TextStyle(
                         // fontSize: 15,
                       // ),
                     // ),
                      SizedBox(height: 4),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: [
                          Text(
                            "Stok: $stock",
                            style: TextStyle(
                              fontSize: 17,
                              color: Colors.green,
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                          SizedBox(width: 5),
                          Icon(
                            Icons.inventory_2,
                            color: Colors.green,
                            size: 16,
                          ),
                        ],
                      ),
                    ],
                  ),
                ),
              ),
            );
          }
        },
      ),
    );
  }

  Widget buildItemLoading(
    String imagePath,
    String itemName,
    String itemDescription,
  ) {
    return Container(
      width: 170,
      height: 250,
      decoration: BoxDecoration(
        color: Colors.grey[200],
        borderRadius: BorderRadius.circular(10),
      ),
      child: Center(child: CircularProgressIndicator()),
    );
  }

  Widget buildItemError(String errorMessage) {
    return Container(
      width: 170,
      height: 250,
      decoration: BoxDecoration(
        color: Colors.grey[200],
        borderRadius: BorderRadius.circular(10),
      ),
      child: Center(
        child: Text(
          'Error: $errorMessage',
          style: TextStyle(color: Colors.red),
        ),
      ),
    );
  }

  Future<Map<String, dynamic>> fetchStock(String itemName) async {
    // final url = Uri.parse('http://localhost:1323/getstockobat');
    final url = Uri.parse('http://10.0.2.2:1323/getstockobat');

    try {
      final response = await http.get(url);

      if (response.statusCode == 200) {
        List<dynamic> items = jsonDecode(response.body);

        print('Response from API: $items'); // Log response from API

        // Find the item with the matching item name
        var item = items.firstWhere(
          (element) => element['nama_obat'] == itemName,
          orElse: () => null,
        );

        if (item != null) {
          print('Item found: $item'); // Log the found item
          return item;
        } else {
          throw Exception('Item not found');
        }
      } else {
        throw Exception('Failed to load stock');
      }
    } catch (e) {
      throw Exception('Error: $e');
    }
  }

  void changeStock(BuildContext context, String itemName, int currentStock) async {
    // Simulate updating stock
    int newStock = currentStock + 1;

    // final url = Uri.parse('http://localhost:1323/updateStock');
    final url = Uri.parse('http://10.0.2.2:1323/updateStock');

    try {
      final response = await http.post(
        url,
        body: jsonEncode({
          'itemName': itemName,
          'newStock': newStock,
        }),
        headers: {'Content-Type': 'application/json'},
      );

      if (response.statusCode == 200) {
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(
            content: Text('Stock updated successfully'),
          ),
        );
      } else {
        showDialog(
          context: context,
          builder: (context) => AlertDialog(
            title: Text('Failed to Update Stock'),
            content: Text('Failed to update stock for $itemName.'),
            actions: [
              TextButton(
                onPressed: () {
                  Navigator.of(context).pop();
                },
                child: Text('OK'),
              ),
            ],
          ),
        );
      }
    } catch (e) {
      showDialog(
        context: context,
        builder: (context) => AlertDialog(
          title: Text('Error'),
          content: Text('Failed to connect to server: $e'),
          actions: [
            TextButton(
              onPressed: () {
                Navigator.of(context).pop();
              },
              child: Text('OK'),
            ),
          ],
        ),
      );
    }
  }
}

void main() {
  runApp(MaterialApp(
    home: Scaffold(
      appBar: AppBar(
        title: Text('Pharmacy App'),
      ),
      body: FavoritItemsWidget(),
    ),
  ));
}
