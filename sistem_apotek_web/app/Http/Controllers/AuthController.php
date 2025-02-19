<?php

namespace App\Http\Controllers;

use App\Models\User;
use GuzzleHttp\Client;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Facades\Validator;
use Illuminate\Validation\ValidationException;

class AuthController extends Controller
{
    // private $client;

    // public function __construct()
    // {
    //     $this->client = new Client(['base_uri' => 'http://localhost:1323']);
    // }

    public function login(){
        return view('auth/login');
    }

    public function loginAction(Request $request)
    {
        $client = new Client();
        $response = $client->post('http://localhost:1323/loginlaravel', [
            'json' => [
                'email' => $request->input('email'),
                'password' => $request->input('password'),
            ]
        ]);

        $body = $response->getBody();
        $data = json_decode($body, true);

        if (isset($data['token'])) {
            // return response()->json(['token' => $data['token']]);
            return redirect()->route('dashboard');
        }
        
        return response()->json(['error' => 'Invalid credentials'], 401);
    
    }

    public function logout(Request $request)
    {
        Auth::guard('web')->logout();
  
        $request->session()->invalidate();
  
        return redirect('login');
    }
 
    public function profile(){
        return view('profile');
    }


}