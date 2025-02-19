@extends('layout.app')

@section('contents')
    <div class="d-flex align-items-center justify-content-between">
        <h1 class="mb-0">List Obat</h1>
        <a href="{{ route('obats.create') }}" class="btn btn-primary">Tambah Obat</a>
    </div>
    <hr />
    @if(Session::has('success'))
        <div class="alert alert-success" role="alert">
            {{ Session::get('success') }}
        </div>
    @endif
    <div class="card">
        <div class="card-body">
            <div class="table-responsive">
                <table class="table table-hover">
                    <thead class="datatable table table-hover table-center mb-0">
                        <tr>
                            <th>#</th>
                            <th>Nama Obat</th>
                            <th>Kode Obat</th>
                            <th>Kode Kategori</th>
                            <th>Kode Supplier</th>
                            <th>Jenis Obat</th>
                            <th>Harga</th>
                            <th>Stok</th>
                            <th>Gambar</th>
                            <th>Deskripsi</th>
                            <th class="text-center">Action</th>
                        </tr>
                    </thead>
                    <tbody>
                        @if(count($obat) > 0)
                            @foreach($obat as $rs)
                                <tr>
                                    <td class="align-middle">{{ $loop->iteration }}</td>
                                    <td class="align-middle">{{ $rs->nama_obat }}</td>
                                    <td class="align-middle">{{ $rs->kd_obat }}</td>
                                    <td class="align-middle">{{ $rs->kd_kategori }}</td>
                                    <td class="align-middle">{{ $rs->kd_suplier }}</td>
                                    <td class="align-middle">{{ $rs->jenis_obat }}</td>
                                    <td class="align-middle">{{ $rs->harga }}</td>
                                    <td class="align-middle">{{ $rs->stock }}</td>
                                    <td class="align-middle"><img src="{{ asset('storage/' . $rs->image_path) }}" alt="{{ $rs->nama_obat }}" width="50"></td>
                                    <td class="align-middle">{{ $rs->description }}</td>
                                    
                                    <td class="d-flex justify-content-center align-content-center">
                                        <div class="btn-group m-1" role="group">
                                            <a href="{{ route('obats.edit', $rs->kd_obat) }}" class="btn btn-warning">Edit</a>
                                        </div>
                                        <div class="btn-group m-1" role="group">
                                            <form action="{{ route('obats.destroy', $rs->kd_obat) }}" method="POST" onsubmit="return confirm('Delete?')">
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
                                    <td class="text-center" colspan="9">Obat tidak ditemukan</td>
                            </tr>
                        @endif
                    </tbody>
                </table>
            </div>
        </div>
    </div>
@endsection
