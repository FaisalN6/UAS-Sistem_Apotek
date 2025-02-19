import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;


class ItemPageKapsul extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: MyCustomAppBar(),
      body: SingleChildScrollView(
        child: Padding(
          padding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
          child: Column(
            children: [
              buildItem(
                context,
                imagePath: "images/stimuno_forte.jpg",
                itemName: "Stimuno Forte",
                itemDescription: "Suplemen untuk memperkuat daya tahan tubuh",
              ),
              buildItem(
              context,
              imagePath: "images/diapet.jpg",
              itemName: "Diapet",
              itemDescription: "Kapsul Untuk mencret",
            ),

              //add item

            ],
          ),
        ),
      ),
    );
  }

  Widget buildItem(
    BuildContext context, {
    required String imagePath,
    required String itemName,
    required String itemDescription,
  }) {
    return Padding(
      padding: EdgeInsets.symmetric(vertical: 10),
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
            return GestureDetector(
              onTap: () {
                // Handle item tap
              },
              child: Container(
                width: 380,
                height: 150,
                decoration: BoxDecoration(
                  color: Colors.white,
                  borderRadius: BorderRadius.circular(10),
                  boxShadow: [
                    BoxShadow(
                      color: Colors.grey.withOpacity(0.5),
                      spreadRadius: 3,
                      blurRadius: 10,
                      offset: Offset(0, 3),
                    ),
                  ],
                ),
                child: Row(
                  children: [
                    Material(
                      color: Colors.transparent,
                      child: InkWell(
                        onTap: () {
                          // Handle image tap
                          Navigator.popAndPushNamed(context, "itemPage");
                        },
                        child: Container(
                          alignment: Alignment.center,
                          child: Image.asset(
                            imagePath,
                            width: 160,
                            height: 180,
                          ),
                        ),
                      ),
                    ),
                    Container(
                      width: 180,
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        mainAxisAlignment: MainAxisAlignment.spaceAround,
                        children: [
                          Text(
                            itemName,
                            style: TextStyle(
                              fontSize: 22,
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                          Text(
                            itemDescription,
                            style: TextStyle(
                              fontSize: 13,
                            ),
                          ),
                          Row(
                            children: [
                              Text(
                                "Stok: $stock",
                                style: TextStyle(
                                  fontSize: 17,
                                  fontWeight: FontWeight.bold,
                                ),
                              ),
                              SizedBox(width: 10),
                              Icon(
                                Icons.inventory,
                                color: Colors.green,
                                size: 20,
                              ),
                            ],
                          ),
                        ],
                      ),
                    ),
                  ],
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
      width: 380,
      height: 150,
      decoration: BoxDecoration(
        color: Colors.grey[200],
        borderRadius: BorderRadius.circular(10),
      ),
      child: Center(child: CircularProgressIndicator()),
    );
  }

  Widget buildItemError(String errorMessage) {
    return Container(
      width: 380,
      height: 150,
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

        // Find the item with the matching item name
        var item = items.firstWhere(
          (element) => element['nama_obat'] == itemName,
          orElse: () => null,
        );

        if (item != null) {
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
}

class MyCustomAppBar extends StatelessWidget implements PreferredSizeWidget {
  @override
  final Size preferredSize;

  MyCustomAppBar({Key? key})
      : preferredSize = Size.fromHeight(60.0),
        super(key: key);

  @override
  Widget build(BuildContext context) {
    return AppBar(
      flexibleSpace: Container(
        decoration: BoxDecoration(
          gradient: LinearGradient(
            colors: [Colors.blue, Colors.lightBlueAccent],
            begin: Alignment.topLeft,
            end: Alignment.bottomRight,
          ),
        ),
      ),
      title: Center(
        child: Text(
          'Kapsul',
          style: TextStyle(
            fontSize: 22,
            fontWeight: FontWeight.bold,
            color: Colors.white,
            fontFamily: 'Cursive',
            shadows: [
              Shadow(
                blurRadius: 10.0,
                color: Colors.black45,
                offset: Offset(2.0, 2.0),
              ),
            ],
          ),
        ),
      ),
      leading: IconButton(
        icon: Icon(Icons.arrow_back, color: Colors.white),
        onPressed: () {
          Navigator.pop(context);
        },
      ),
      
      elevation: 10.0,
      shadowColor: Colors.black.withOpacity(0.5),
    );
  }
}

void main() {
  runApp(MaterialApp(
    home: Scaffold(
      appBar: AppBar(
        title: Text('Pharmacy App'),
      ),
      body: ItemPageKapsul(),
    ),
  ));
}
