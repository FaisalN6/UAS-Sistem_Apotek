import 'package:flutter/material.dart';
import 'package:sistemapotek/pages/Homepage.dart';
import 'package:sistemapotek/pages/ItemPage.dart';
import 'package:sistemapotek/pages/ItemPageSalep.dart';
import 'package:sistemapotek/pages/ItemPageSirup.dart';
import 'package:sistemapotek/pages/ItemPageVitamin.dart';
import 'package:sistemapotek/pages/itemPageKapsul.dart';
import 'package:sistemapotek/pages/itemPageTablet.dart';
import 'package:sistemapotek/screens/SplashScreen.dart';

void main() {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: "Sistem Apotek",
      debugShowCheckedModeBanner: false,
      theme: ThemeData(
        primaryColor: Color(0xFF5C6BC0), // Warna primer aplikasi
        scaffoldBackgroundColor: Colors.white, // Warna latar belakang scaffold
        appBarTheme: AppBarTheme(
          elevation: 0, // Menghilangkan bayangan di app bar
          color: Color(0xFF5C6BC0), // Warna app bar
        ),
      ),
      initialRoute: '/',
      routes: {
        '/': (context) => SplashScreen(),
        '/homepage': (context) => Homepage(),
        '/itemPage': (context) => ItemPage(),
        '/itemPageSirup': (context) => ItemPageSirup(),
        '/itemPageSalep': (context) => ItemPageSalep(),
        '/itemPageKapsul': (context) => ItemPageKapsul(),
        '/itemPageVitamin': (context) => ItemPageVitamin(),
        '/itemPageTablet': (context) => ItemPageTablet(),
      },
    );
  }
}
