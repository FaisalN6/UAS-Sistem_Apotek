<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use GuzzleHttp\Client;
use App\Models\supplier;

class supplierController extends Controller
{
    private $client;

    public function __construct()
    {
        $this->client = new Client(['base_uri' => 'http://localhost:1323']);
    }


    public function index()
    {
        $response = $this->client->get('/supliers');
        $supplier = json_decode($response->getBody()->getContents());

        return view('suppliers.supplier', compact('supplier'));   
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create()
    {
        return view('suppliers.create');
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request)
    {
        $data = $request->only(['kd_suplier','nama_suplier', 'no_tlpn', 'alamat', 'perusahaan']);

        $response = $this->client->post('/suplier',['json' => array_merge($data)]);
        // $supplier = json_decode($response->getBody()->getContents());
    
        if ($response->getStatusCode() == 201) {
            return redirect()->route('supplier')->with('success', 'Kategori berhasil ditambahkan');
        } else {
            return redirect()->back()->with('error', 'Gagal menambahkan kategori');
        }
    }


    public function edit($kd_suplier)
    {
        $response = $this->client->get("/suplier/{$kd_suplier}");
        $supplier = json_decode($response->getBody()->getContents());

        return view('suppliers.edit', compact('supplier'));
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, string $kd_suplier)
    {
        $data = $request->only(['nama_suplier', 'no_tlpn', 'alamat', 'perusahaan']);

        $response = $this->client->put("/suplier/{$kd_suplier}", [
            'json' => array_merge($data, ['kd_suplier' => $kd_suplier])
        ]);

        if ($response->getStatusCode() == 200) {
            return redirect()->route('supplier')->with('success', 'Kategori berhasil diperbarui');
        } else {
            return redirect()->back()->with('error', 'Gagal memperbarui kategori');
        }
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy($kd_suplier)
    {
        $response = $this->client->delete("/suplier/{$kd_suplier}"
        );

        if ($response->getStatusCode() == 200) {
            return redirect()->route('supplier')->with('success', 'Suplier berhasil dihapus');
        } else {
            return redirect()->back()->with('error', 'Gagal menghapus Ssuplier');
        }
    }
}
