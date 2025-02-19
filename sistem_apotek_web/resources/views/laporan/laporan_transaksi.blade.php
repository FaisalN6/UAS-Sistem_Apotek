@extends('layout.app')

@section('contents')
    <div class="d-flex align-items-center justify-content-between">
        <h1 class="mb-0">List Obat</h1>
        <a href="" class="btn btn-primary">Tambah Obat</a>
    </div>
    <hr />
    @if(Session::has('success'))
        <div class="alert alert-success" role="alert">
            {{ Session::get('success') }}
        </div>
    @endif
    <div class="card">
        <div class="d-flex justify-content-between mb-3">
            <button onclick="printTable()" class="btn btn-primary">Print</button>
        </div>
        <div class="card-body">
            <div class="table-responsive">
                <table class="table table-hover">
                    <thead class="datatable table table-hover table-center mb-0">
                        <tr>
                            <th>#</th>
                            <th>Kode Transaksi</th>
                            <th>Nama Obat</th> // kd_obat
                            <th>Kategori</th> // kd_kategori
                            <th>QTY</th>
                            <th>Harga</th> // kd_pbat
                            <th>Total Harga</th>
                            <th>Tanggal</th>
                            <th class="text-center">Action</th>
                        </tr>
                    </thead>
                    <tbody>
                        {{-- @if($transaksi->count() > 0) --}}
                        {{-- @if(count($transaksi) > 0)
                            @foreach($transaksi as $rs)
                                <tr>
                                    <td class="align-middle">{{ $loop->iteration }}</td>
                                    <td class="align-middle">{{ $rs->kd_transksi }}</td>
                                    <td class="align-middle">{{ $rs->nama_obat }}</td>
                                    <td class="align-middle">{{ $rs->kategori }}</td>
                                    <td class="align-middle">{{ $rs->qty }}</td>
                                    <td class="align-middle">{{ $rs->harga }}</td>
                                    <td class="align-middle">{{ $rs->total_harga }}</td>
                                    <td class="align-middle">{{ $rs->tanggal }}</td>
                                    <td class="d-flex justify-content-center align-content-center">
                                        <div class="btn-group m-1" role="group">
                                            <a href="" class="btn btn-warning">Edit</a>
                                        </div>
                                        <div class="btn-group m-1" role="group">
                                            <form action="" method="POST" onsubmit="return confirm('Delete?')">
                                                @csrf
                                                @method('DELETE')
                                                <button class="btn btn-danger">Delete</button>
                                            </form>
                                        </div>
                                    </td>
                                </tr>
                            @endforeach
                        @else
                            <tr>
                                    <td class="text-center" colspan="9">Transaksi tidak ditemukan</td>
                            </tr>
                        @endif --}}
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    
    <script>
        function printTable() {
              const divToPrint = document.getElementById('medicineTable');
              const newWin = window.open('');
              newWin.document.write('<html><head><title>Print</title>');
              newWin.document.write('<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">');
              newWin.document.write('</head><body>');
              newWin.document.write(divToPrint.outerHTML);
              newWin.document.write('</body></html>');
              newWin.document.close();
              newWin.print();
          }
      </script>
@endsection
