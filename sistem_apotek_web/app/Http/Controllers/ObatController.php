<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use GuzzleHttp\Client;
use App\Models\Obat;

class ObatController extends Controller
{
    private $client;

    public function __construct()
    {
        $this->client = new Client(['base_uri' => 'http://localhost:1323']);
    }

    public function index()
    {
        $response = $this->client->get('/getstockobat');
        $obat = json_decode($response->getBody()->getContents());

        return view('obats.index', compact('obat'));
    }

    public function create()
    {
        return view('obats.create');
    }

    public function store(Request $request)
    {
        // Ambil file yang diunggah
        $file = $request->file('image_path');
        $imagePath = null;
    
        // Jika ada file yang diunggah, convert file menjadi string
        if ($file) {
            $imagePath = base64_encode(file_get_contents($file->getPathname()));
        }
    
        // Gabungkan ke dalam data yang akan dikirimkan ke backend Go
        $data = $request->except('image_path');
        $data['image_path'] = $imagePath;
    
        // Ubah 'stock' ke integer jika perlu
        $data['stock'] = (int) $data['stock'];
    
        // Kirim data ke backend Go
        $response = $this->client->put('/addItem', [
            'json' => $data
        ]);
    
        if ($response->getStatusCode() == 201) {
            return redirect()->route('obats')->with('success', 'Obat berhasil ditambahkan');
        } else {
            return redirect()->back()->with('error', 'Gagal menambahkan obat');
        }
    }


    public function edit($kd_obat)
    {
        // Ambil data obat dari backend atau database
        $response = $this->client->get("/getstockobat/{$kd_obat}");
        $obat = json_decode($response->getBody()->getContents());

        return view('obats.edit', compact('obat'));
    }

    public function update(Request $request, $kd_obat)
    {
        $data = $request->only(['stock', 'harga', 'kd_kategori', 'kd_suplier']);
        $data['stock'] = (int)$data['stock']; // Ensure stock is an integer

        $response = $this->client->post('/updateStock', [
            'json' => array_merge($data, ['kd_obat' => $kd_obat])
        ]);

        if ($response->getStatusCode() == 200) {
            return redirect()->route('obats')->with('success', 'Obat berhasil diperbarui');
        } else {
            return redirect()->back()->with('error', 'Gagal memperbarui obat');
        }
    }

    public function destroy(string $id)
    {
        $response = $this->client->delete('/deleteItem', [
            'json' => ['kd_obat' => $id]
        ]);

        if ($response->getStatusCode() == 200) {
            return redirect()->route('obats')->with('success', 'Obat berhasil dihapus');
        } else {
            return redirect()->back()->with('error', 'Gagal menghapus obat');
        }
    }

}
