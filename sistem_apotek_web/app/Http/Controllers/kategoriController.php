<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use GuzzleHttp\Client;
use App\Models\kategori;

class kategoriController extends Controller
{
    private $client;

    public function __construct()
    {
        $this->client = new Client(['base_uri' => 'http://localhost:1323']);
    }

    public function index()
    {
        $response = $this->client->get('/kategoris');
        $kategori = json_decode($response->getBody()->getContents());

        return view('kategoris.kategori', compact('kategori'));
    }


    public function create()
    {
        return view('kategoris.create');
    }


    public function store(Request $request)
    {
        // Kirim data ke backend Go
        $response = $this->client->post('/kategori',['json' => $request->all()]);
        $kategori = json_decode($response->getBody()->getContents());
    
        if ($response->getStatusCode() == 201) {
            return redirect()->route('kategori')->with('success', 'Kategori berhasil ditambahkan');
        } else {
            return redirect()->back()->with('error', 'Gagal menambahkan kategori');
        }
    }


    public function edit($kd_kategori)
    {
        $response = $this->client->get("/kategori/{$kd_kategori}");
        $kategori = json_decode($response->getBody()->getContents());

        return view('kategoris.edit', compact('kategori'));
    }


    public function update(Request $request, $kd_kategori)
    {
        $data = $request->only(['nama_kategori']);

        $response = $this->client->put("/kategori/{$kd_kategori}", [
            'json' => array_merge($data, ['kd_kategori' => $kd_kategori])
        ]);

        if ($response->getStatusCode() == 200) {
            return redirect()->route('kategori')->with('success', 'Kategori berhasil diperbarui');
        } else {
            return redirect()->back()->with('error', 'Gagal memperbarui kategori');
        }
    }
    

    public function destroy($kd_kategori)
    {
        $response = $this->client->delete("/kategori/{$kd_kategori}"
        );

        if ($response->getStatusCode() == 200) {
            return redirect()->route('kategori')->with('success', 'Kategori berhasil dihapus');
        } else {
            return redirect()->back()->with('error', 'Gagal menghapus kategori');
        }
    }
}
