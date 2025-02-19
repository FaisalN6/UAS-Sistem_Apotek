@extends('layout.app')

@section('contents')
<div class="d-flex align-items-center justify-content-between">
    <h1 class="mb-0">Supplier</h1>
    <a href="{{ route('suppliers.create') }}" class="btn btn-primary">Tambah Supplier</a>
</div>
<hr />
@if(Session::has('success'))
    <div class="alert alert-success" role="alert">
        {{ Session::get('success') }}
    </div>
@endif
<!-- Recent Orders -->
<div class="card">
    <div class="card-body">
        <div class="table-responsive">
            <table class="table table-hover">
                <thead class="datatable table table-hover table-center mb-0">
                    <tr>
                        <th>#</th>
                        <th>Kode Suplier</th>
                        <th>Nama Suplier</th>
                        <th>No. Telepon</th>
                        <th>Alamat</th>
                        <th>Perusahaan</th>
                        <th class="text-center">Action</th>
                    </tr>
                </thead>
                <tbody>
                    @if(count($supplier) > 0)
                        @foreach($supplier as $rs)
                            <tr>
                                <td class="align-middle">{{ $loop->iteration }}</td>
                                <td class="align-middle">{{ $rs->kd_suplier }}</td>
                                <td class="align-middle">{{ $rs->nama_suplier }}</td>
                                <td class="align-middle">{{ $rs->no_tlpn }}</td>
                                <td class="align-middle">{{ $rs->alamat }}</td>
                                <td class="align-middle">{{ $rs->perusahaan }}</td>
                                <td class="d-flex justify-content-center align-content-center">
                                    <div class="btn" role="group" aria-label="Basic example" >
                                        <a href="{{ route('suppliers.edit', $rs->kd_suplier) }}" type="button" class="btn btn-warning " style="font-weight: bold;">Ubah</a>
                                        <form action="{{ route('suppliers.destroy', $rs->kd_suplier) }}" method="POST" type="button" class="btn btn--danger p-0" onsubmit="return confirm('Apakah data ingin dihapus?')">
                                            @csrf
                                            @method('DELETE')
                                            <button class="btn btn-danger m-0" style="font-weight: bold;">Hapus</button>
                                        </form>    
                                    </div>
                                </td>
                            </tr>
                        @endforeach
                    @else
                        <tr>
                            <td class="text-center" colspan="9">Supplier tidak ditemukan</td>
                        </tr>
                    @endif
                </tbody>
            </table>
        </div>
    </div>
</div>
@endsection
