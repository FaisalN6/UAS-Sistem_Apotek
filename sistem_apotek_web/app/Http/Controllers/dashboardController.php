<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use GuzzleHttp\Client;


class dashboardController extends Controller
{
    private $client;

    public function __construct()
    {
        $this->client = new Client(['base_uri' => 'http://localhost:1323']);
    }

    public function tblVwObat(){
        $response = $this->client->get('/getstockobat');
        $home = json_decode($response->getBody()->getContents());

        return view('dashboard', compact('home'));
    }
}
