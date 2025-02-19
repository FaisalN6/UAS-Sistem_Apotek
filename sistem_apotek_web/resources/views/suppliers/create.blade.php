@extends('layout.app')
  
{{-- @section('title', 'Tambah Obat') --}}

@section('contents')
    <h1 class="mb-0">Tambah Supplier</h1>
    <hr />
    <div class="container">
    <div class="card p-0" style="width: 80%; margin: auto; border-top: 5px solid #218CFF;">
        <div class="card-body">
            <div class="form-group">
                <h3 class="mb-0">Form tambah supplier</h3>
                <hr />
                <form action="{{ route('suppliers.store') }}" method="POST" enctype="multipart/form-data">
                    @csrf      
                    {{-- kode Obat --}}
                    <div class="col mb-3">
                        <label for="kdSupplier">Kode Supplier</label>
                        <input type="text" name="kd_suplier" id="kdSupplier" class="form-control" placeholder="Kode Supplier">
                    </div>
                    {{-- /kode Obat --}}

                    {{-- Nama Obat --}}
                    <div class="col mb-3">
                        <label for="namaSupplier">Nama Supplier</label>
                        <input type="text" name="nama_suplier" id="namaSupplier" class="form-control" placeholder="Nama Supplier">
                    </div>
                    {{-- /Nama Obat --}}

                    
                    {{-- No Telp Obat --}}
                    <div class="col mb-3">
                        <label for="no_tlpn">No. Telepon</label>
                        <input type="text" name="no_tlpn" id="no_tlpn" class="form-control" placeholder="08XX">
                    </div>
                    {{-- /Nama Obat --}}

                    {{-- Alamat --}}
                    <div class="col mb-3">
                        <label for="alamat">Alamat</label>
                        <input type="text" name="alamat" id="Alamat" class="form-control" placeholder="Alamat">
                    </div>
                    {{-- /Alamat --}}

                    {{-- perusahaan --}}
                    <div class="col mb-3">
                        <label for="Perusahaan">Perusahaan</label>
                        <input type="text" name="perusahaan" id="Perusahaan" class="form-control" placeholder="Perusahaan">
                    </div>
                    {{-- /perusahaan --}}

                        <div class="col text-right">
                            {{-- <button type="submit" class="btn btn-secondary">Batal</button> --}}
                            <a href="{{ route('supplier') }}" type="button" class="btn btn-secondary">Batal</a>
                            <button type="submit" class="btn btn-primary">Submit</button>
                        </div>
                </form>
            </div>
        </div>
    </div>
    </div>
@endsection