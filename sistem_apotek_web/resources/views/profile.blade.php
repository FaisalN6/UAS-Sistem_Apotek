@extends('layout.app')
  
@section('contents')
    <h1 class="mb-0">Profile</h1>
    <hr />

<div class="container">
    <div class="card p-0" style="width: 80%; margin: auto; border-top: 5px solid #218CFF;">
        <div class="card-body">
            <div class="form-group">
                <h3 class="mb-0">Profile Settings</h3>
                <hr />
                <form method="POST" enctype="multipart/form-data" id="profile_setup_frm" action="" >
                    <div class="row">
                        <div class="col-md-12 border-right">
                            <div class="p-3 py-5">
                                <div class="row" id="res"></div>
                                <div class="row mt-2">
                  
                                    <div class="col-md-6">
                                        <label class="labels">Name</label>
                                        <input type="text" name="name" class="form-control" placeholder="first name" value="{{ user()->name }}">
                                    </div>
                                    <div class="col-md-6">
                                        <label class="labels">Email</label>
                                        <input type="text" name="email" disabled class="form-control" value="{{ user()->email }}" placeholder="Email">
                                    </div>
                                </div>
                                <div class="row mt-2">
                                    <div class="col-md-6">
                                        <label class="labels">Phone</label>
                                        <input type="text" name="phone" class="form-control" placeholder="Phone Number" value="{{ user()->phone }}">
                                    </div>
                                    <div class="col-md-6">
                                        <label class="labels">Address</label>
                                        <input type="text" name="address" class="form-control" value="{{ user()->address }}" placeholder="Address">
                                    </div>
                                </div>
                                 
                                <div class="mt-5 text-center"><button id="btn" class="btn btn-primary profile-button btn-block" type="submit">Save Profile</button></div>
                            </div>
                        </div>
                         
                    </div>   
                            
                        </form>
            </div>
        </div>
    </div>
    </div>
@endsection