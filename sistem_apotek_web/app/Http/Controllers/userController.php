<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\User;
use GuzzleHttp\Client;

use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Facades\Validator;
use Illuminate\Validation\ValidationException;

class userController extends Controller
{
    private $client;

    public function __construct()
    {
        $this->client = new Client(['base_uri' => 'http://localhost:1323']);
    }

    public function VWuser(){
        $response = $this->client->get('/users');
        $user = json_decode($response->getBody()->getContents());

        return view('users.index', compact('user'));
    }

    public function createUser(){
        return view('users.create');
    }

    public function storeUser(Request $request){
        $response = $this->client->post('/user/add', [
                            'json' => [
                                'name' => $request->name,
                                'email' => $request->email,
                                'password' => $request->password,
                                'role' => $request->role,
                                // 'token' => 'Admin',
                            ],
                        ]);
                        if ($response->getStatusCode() == 200) {
                            return redirect()->route('user.view')->with('success', 'User telah diperbaharui');
                        } else {
                            return redirect()->back()->with('error', 'Gagal memperbarui kategori');
                        }
    }

    public function editUser(string $id){
        $response = $this->client->get("/user/{$id}");
        $user = json_decode($response->getBody()->getContents());

        return view('users.edit', compact('user'));
    }

    public function updateUser(Request $request, string $id){
        $data = $request->only(['name', 'email', 'password', 'role',]);
        // $data['id'] = (int)$data['id']; // Ensure stock is an integer

        $response = $this->client->put("/user/{$id}", [
            'json' => array_merge($data, ['id' => $id])
        ]);

        if ($response->getStatusCode() == 200) {
            return redirect()->route('user.view')->with('success', 'User telah diperbaharui');
        } else {
            return redirect()->route('user.view')->with('error', 'Gagal memperbarui user');
        }
    }

    public function destroyUser(string $id){
        $response = $this->client->delete("/user/{$id}"
        );

        if ($response->getStatusCode() == 200) {
            return redirect()->route('user.view')->with('success', 'User telah diperbaharui');
        } else {
            return redirect()->back()->with('error', 'Gagal memperbarui user');
        }
    }
}
