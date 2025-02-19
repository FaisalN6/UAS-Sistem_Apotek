import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;

class NewestItemsWidget extends StatefulWidget {
  final String searchQuery;

  const NewestItemsWidget({Key? key, required this.searchQuery}) : super(key: key);

  @override
  _NewestItemsWidgetState createState() => _NewestItemsWidgetState();
}

class _NewestItemsWidgetState extends State<NewestItemsWidget> {
  late Future<List<Map<String, dynamic>>> _itemsFuture;

  @override
  void initState() {
    super.initState();
    _itemsFuture = fetchItemsFromDatabase();
  }

  Future<void> _refresh() async {
    setState(() {
      _itemsFuture = fetchItemsFromDatabase();
    });
  }

  Future<List<Map<String, dynamic>>> fetchItemsFromDatabase() async {
    // final url = Uri.parse('http://localhost:1323/getstockobat');
    final url = Uri.parse('http://10.0.2.2:1323/getstockobat');
    try {
      final response = await http.get(url);
      if (response.statusCode == 200) {
        List<dynamic> items = jsonDecode(response.body);
        return items.cast<Map<String, dynamic>>();
      } else {
        throw Exception('Failed to load items');
      }
    } catch (e) {
      throw Exception('Error: $e');
    }
  }

  @override
  Widget build(BuildContext context) {
    return RefreshIndicator(
      onRefresh: _refresh,
      child: FutureBuilder<List<Map<String, dynamic>>>(
        future: _itemsFuture,
        builder: (context, snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return Center(child: CircularProgressIndicator());
          } else if (snapshot.hasError) {
            return Center(child: Text('Error: ${snapshot.error}'));
          } else if (!snapshot.hasData || snapshot.data!.isEmpty) {
            return Center(child: Text('No items found in the database'));
          } else {
            List<Map<String, dynamic>> filteredItems = snapshot.data!
                .where((item) =>
                    item['nama_obat'].toLowerCase().contains(widget.searchQuery.toLowerCase()))
                .toList();

            if (filteredItems.isEmpty) {
              return Center(child: Text('No matching items'));
            }

            return SingleChildScrollView(
              child: Padding(
                padding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
                child: Column(
                  children: filteredItems.map((item) {
                    return buildItem(
                      context,
                      imagePath: item['image_path'] ?? 'images/default_image.jpg',
                      itemName: item['nama_obat'],
                      itemDescription: item['description'],
                      stock: item['stock'],
                    );
                  }).toList(),
                ),
              ),
            );
          }
        },
      ),
    );
  }

  Widget buildItem(
    BuildContext context, {
    required String imagePath,
    required String itemName,
    required String itemDescription,
    required int stock,
  }) {
    return Padding(
      padding: EdgeInsets.symmetric(vertical: 10),
      child: Container(
        width: MediaQuery.of(context).size.width - 20,
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
            Container(
              width: 160,
              height: 150,
              decoration: BoxDecoration(
                borderRadius: BorderRadius.only(
                  topLeft: Radius.circular(10),
                  bottomLeft: Radius.circular(10),
                ),
                image: DecorationImage(
                  image: NetworkImage(imagePath),
                  fit: BoxFit.cover,
                ),
              ),
            ),
            Expanded(
              child: Padding(
                padding: EdgeInsets.symmetric(horizontal: 10),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  mainAxisAlignment: MainAxisAlignment.spaceAround,
                  children: [
                    Text(
                      itemName,
                      style: TextStyle(
                        fontSize: 18,
                        fontWeight: FontWeight.bold,
                      ),
                      maxLines: 1,
                      overflow: TextOverflow.ellipsis,
                    ),
                    Text(
                      itemDescription,
                      style: TextStyle(
                        fontSize: 12,
                        color: Colors.grey,
                      ),
                      maxLines: 2,
                      overflow: TextOverflow.ellipsis,
                    ),
                    Row(
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
          ],
        ),
      ),
    );
  }
}
