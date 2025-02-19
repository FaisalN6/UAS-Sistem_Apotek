@extends('layout.app')

@section('title', 'Dashboard - Manager')

@section('contents')
                    <!-- Content Row -->
                    <div class="row">

                        {{-- <!-- Pemasukan  -->
                        <div class="col-xl-3 col-md-6 mb-4">
                            <div class="card border-left-primary shadow h-100 py-2">
                                <div class="card-body">
                                    <div class="row no-gutters align-items-center">
                                        <div class="col mr-2">
                                            <div class="text-xs font-weight-bold text-primary text-uppercase mb-1">
                                                Pendapatan (Bulanan)</div>
                                            <div class="h5 mb-0 font-weight-bold text-gray-800">124558</div>
                                        </div>
                                        <div class="col-auto">
                                            <i class="fas fa-calendar fa-2x text-gray-300"></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Earnings (Monthly) Card Example -->
                        <div class="col-xl-3 col-md-6 mb-4">
                            <div class="card border-left-success shadow h-100 py-2">
                                <div class="card-body">
                                    <div class="row no-gutters align-items-center">
                                        <div class="col mr-2">
                                            <div class="text-xs font-weight-bold text-success text-uppercase mb-1">
                                                Pendapatan (Tahunan)</div>
                                            <div class="h5 mb-0 font-weight-bold text-gray-800">$215,000</div>
                                        </div>
                                        <div class="col-auto">
                                            <i class="fas fa-dollar-sign fa-2x text-gray-300"></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Earnings (Monthly) Card Example -->
                        <div class="col-xl-3 col-md-6 mb-4">
                            <div class="card border-left-info shadow h-100 py-2">
                                <div class="card-body">
                                    <div class="row no-gutters align-items-center">
                                        <div class="col mr-2">
                                            <div class="text-xs font-weight-bold text-info text-uppercase mb-1">Total Obat
                                            </div>
                                            <div class="row no-gutters align-items-center">
                                                <div class="col-auto">
                                                    <div class="h5 mb-0 mr-3 font-weight-bold text-gray-800">50%</div>
                                                </div>
                                                <div class="col">
                                                    <div class="progress progress-sm mr-2">
                                                        <div class="progress-bar bg-info" role="progressbar"
                                                            style="width: 50%" aria-valuenow="50" aria-valuemin="0"
                                                            aria-valuemax="100"></div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-auto">
                                            <i class="fas fa-clipboard-list fa-2x text-gray-300"></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Pending Requests Card Example -->
                        <div class="col-xl-3 col-md-6 mb-4">
                            <div class="card border-left-warning shadow h-100 py-2">
                                <div class="card-body">
                                    <div class="row no-gutters align-items-center">
                                        <div class="col mr-2">
                                            <div class="text-xs font-weight-bold text-warning text-uppercase mb-1">
                                                Jumlah User</div>
                                            <div class="h5 mb-0 font-weight-bold text-gray-800">18</div>
                                        </div>
                                        <div class="col-auto">
                                            <i class="fas fa-comments fa-2x text-gray-300"></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
 --}}
                    <!-- Content Row -->

                    <div class="row">

                        <!-- Area Chart -->
                        <div class="col-xl-8 col-lg-7">
                            <div class="card shadow mb-4">
                                <!-- Card Header - Dropdown -->
                                <div
                                    class="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                                    <h6 class="m-0 font-weight-bold text-primary">Daftar Obat</h6>
                                    <div class="d-flex justify-content-between mb-3">
                                        <button onclick="printTable()" class="btn btn-primary">Print</button>
                                    </div>
                                </div>
                                <!-- Card Body -->
                                <div class="card-body">
                                    <div class="table-responsive" style="max-height: 400px; overflow: auto;">
                                        <table id="medicineTable" class="table table-hover">
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
                                                    <th>Deskripsi</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                @if(!is_null($home) && count($home) > 0)
                                                    @foreach($home as $rs)
                                                        <tr>
                                                            <td class="align-middle">{{ $loop->iteration }}</td>
                                                            <td class="align-middle">{{ $rs->nama_obat }}</td>
                                                            <td class="align-middle">{{ $rs->kd_obat }}</td>
                                                            <td class="align-middle">{{ $rs->kd_kategori }}</td>
                                                            <td class="align-middle">{{ $rs->kd_suplier }}</td>
                                                            <td class="align-middle">{{ $rs->jenis_obat }}</td>
                                                            <td class="align-middle">{{ $rs->harga }}</td>
                                                            <td class="align-middle">{{ $rs->stock }}</td>
                                                            <td class="align-middle">{{ $rs->description }}</td>
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
                        </div>

                        <!-- Pie Chart -->
                        <div class="col-xl-4 col-lg-5">
                            <div class="card shadow mb-4">
                                <!-- Card Header - Dropdown -->
                                <div
                                    class="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                                    <h6 class="m-0 font-weight-bold text-primary">Hasil Transaksi</h6>
                                </div>
                                <!-- Card Body -->
                                <div class="card-body">
                                    <div class="table-responsive" style="max-height: 400px; overflow: auto;">
                                        <table class="table table-hover">
                                            <thead class="datatable table table-hover table-center mb-0">
                                                <tr>
                                                    <th>#</th>
                                                    <th>Kode Transaksi</th>
                                                    <th>Struk</th>
                                                    <th>Nama Obat</th>
                                                    <th>Harga</th>
                                                    <th>Jumlah</th>
                                                    <th>Total</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                {{-- @if(count($home) > 0)
                                                    @foreach($home as $rs)
                                                        <tr>
                                                            <td class="align-middle">{{ $loop->iteration }}</td>
                                                            <td class="align-middle">{{ $rs->nama_obat }}</td>
                                                            <td class="align-middle">{{ $rs->kd_obat }}</td>
                                                            <td class="align-middle">{{ $rs->kd_kategori }}</td>
                                                            <td class="align-middle">{{ $rs->kd_suplier }}</td>
                                                            <td class="align-middle">{{ $rs->jenis_obat }}</td>
                                                            <td class="align-middle">{{ $rs->harga }}</td>
                                                            <td class="align-middle">{{ $rs->stock }}</td>
                                                            <td class="align-middle">{{ $rs->description }}</td>
                                                        </tr>
                                                    @endforeach
                                                @else
                                                    <tr>
                                                            <td class="text-center" colspan="9">Obat tidak ditemukan</td>
                                                    </tr>
                                                @endif --}}
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <!-- Content Row -->
                    <div class="row">

                        
                    </div>

                </div>
                <!-- /.container-fluid -->

            </div>
            <!-- End of Main Content -->

           
        </div>
        <!-- End of Content Wrapper -->

    </div>
    <!-- End of Page Wrapper -->

    <!-- Scroll to Top Button-->
    <a class="scroll-to-top rounded" href="#page-top">
        <i class="fas fa-angle-up"></i>
    </a>

     <!-- Bootstrap core JavaScript-->
     <script src="{{ asset('assets/vendor/jquery/jquery.min.js') }}"></script>
    <script src="{{ asset('assets/vendor/bootstrap/js/bootstrap.bundle.min.js') }}"></script>

    <!-- Core plugin JavaScript-->
    <script src="{{ asset('assets/vendor/jquery-easing/jquery.easing.min.js') }}"></script>

    <!-- Custom scripts for all pages-->
    <script src="{{ asset('assets/js/sb-admin-2.min.js') }}"></script>

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