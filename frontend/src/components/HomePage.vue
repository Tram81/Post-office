<template>
    
    <!-- <div class="home">
        <h1>Welcome to Home Page</h1>
        <p>This is a simple home page built with Vue 3.</p>
    </div> -->

    <section class="about_section ">
    <div class="container">
      <div class="row">
        <div class="col">
          <h2 class="heading_style">
            About Us
          </h2>
          <p>
            Nhanh chóng, an toàn, và tiện lợi - Quản lý bưu điện thông minh trong tầm tay bạn!
          </p>
        </div>

      </div>
      <div class="row">
        <div class="col-md-6">
          <div class="about_img-box">

            <img src="images/a-truck.jpg" alt="" class="img-fluid">
          </div>
        </div>
        <div class="col-md-6 about_detail-container">
          <div class="about_detail-box">
            <h3>
              Quản lý bưu điện
            </h3>
            <p>
              Chào mừng bạn đến với trang web quản lý bưu điện của chúng tôi! Đây là nền tảng hiện đại, giúp tối ưu hóa quy trình vận chuyển và giao nhận bưu phẩm. Với giao diện thân thiện, bạn dễ dàng theo dõi, quản lý và tra cứu thông tin bưu kiện mọi lúc, mọi nơi. Hệ thống bảo mật cao, đảm bảo an toàn tuyệt đối cho thông tin khách hàng. Hãy trải nghiệm dịch vụ bưu điện thông minh và tiện ích với chúng tôi ngay hôm nay!
            </p>
            <div class="d-flex  justify-content-end">
              <a href="" class="quote-btn about-btn">
                <img src="images/white-next.png" alt="">
                <span>
                  About More
                </span>

              </a>
            </div>
          </div>
        </div>
      </div>
    </div>

  </section>

  <!-- end about section -->

  <!-- service section -->
  <section class="service_section layout_padding">
    <div class="container">
      <br class="d-flex justify-content-center">
        <h2 class="heading_style">
          Our Services 
        </h2>
      
      <div class="row layout_padding2-top">
        <div class="col-md-4">
          <div class="service_img-box s-b-1">
            <img src="images/service-1.jpg" alt="">
            <div class="d-flex">
              <h3>
                Nội thành

              </h3>
            </div>
          </div>
          <div class="service-detail">
            <p>
              Nhanh chóng, tiện lợi
            </p>
            
          </div>
        </div>
        <div class="col-md-4">
          <div class="service_img-box s-b-2">
            <img src="images/service-2.jpg" alt="">
            <div class="d-flex">
              <h3>
                Ngoại thành


              </h3>
            </div>
          </div>
          <div class="service-detail">
            <p>
              An toàn, chu đáo
            </p>
            
          </div>
        </div>
        <div class="col-md-4">
          <div class="service_img-box s-b-3">
            <img src="images/service-3.jpg" alt="">
            <div class="d-flex">
              <h3>
                Quốc tế


              </h3>
            </div>
          </div>
          <div class="service-detail">
            <p>
              Tận tay khách hàng du bất cứ nơi đâu
            </p>
            
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- end service section -->


  <!-- shop section -->
  <section class="shop_section">
    <div class="container">
      <div class="d-flex justify-content-center">
        <h2 class="heading_style">
          Our Shop
        </h2>
      </div>
      <div class="row">
        <div class="col-md-6">
          <div class="d-flex align-items-center h-100">
            <div class="shop-detail">
              
              <p>
                1. Mọi thứ bạn cần, chúng tôi đều có - Dịch vụ tận tâm, chất lượng vượt trội!
              </p>
              <p>
                2. Mọi thứ bạn cần, chỉ một cú click - Dịch vụ hoàn hảo!
              </p>
              <p>
                3. Mọi thứ bạn cần, luôn trong tầm tay - Dịch vụ tiện lợi, uy tín hàng đầu!
              </p>
              <p>
                4. Mọi thứ bạn cần, chúng tôi mang đến - Dịch vụ nhanh chóng, an toàn tuyệt đối!
              </p>
              <p>
                5. Mọi thứ bạn cần, chúng tôi sẵn sàng phục vụ - Dịch vụ đáng tin cậy, luôn đồng hành cùng bạn!
              </p>
                
            </div>
          </div>
        </div>
        <div class="col-md-6">
          <div class="shop_img-box">
            <img src="images/gift.jpg" alt="" class="img-fluid">
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- end shop section -->

  <!-- testimonial section -->
  <section class="client_section layout_padding">
    <div class="d-flex justify-content-center">
      <h2 class="heading_style">
        Testimonial
      </h2>
    </div>
    <div id="carouselExampleIndicator" class="carousel slide" data-ride="carousel">
      <ol class="carousel-indicators">
        <li data-target="#carouselExampleIndicator" data-slide-to="0" class="active"></li>
        <li data-target="#carouselExampleIndicator" data-slide-to="1"></li>
        <li data-target="#carouselExampleIndicator" data-slide-to="2"></li>
        <li data-target="#carouselExampleIndicator" data-slide-to="3"></li>
      </ol>
      <div class="carousel-inner">
        <div class="carousel-item active">
          <div class="container">
            <div class="row">
              <div class="col-md-6">
                <div class="client_box c-b-1">
                  <div class="client_img">
                    <img src="images/client.png" alt="" class="img-fluid">
                  </div>
                  <div class="client_detail">
                    <h5>
                      Lịch sử phát triển
                    </h5>
                    <p>
                      Trang web quản lý bưu điện của chúng tôi ra đời năm 2023, với mục tiêu cải thiện quy trình vận chuyển và giao nhận bưu phẩm. Trải qua nhiều ngày phát triển, hệ thống đã liên tục được nâng cấp để đáp ứng nhu cầu ngày càng cao của khách hàng. Hiện nay, trang web đã trở thành một công cụ quản lý bưu phẩm hiệu quả và tiện lợi, được nhiều người tin dùng.
                    </p>
                  </div>
                </div>
              </div>
              <div class="col-md-6">
                <div class="client_box c-b-2">
                  <div class="client_img">
                    <img src="images/client.png" alt="" class="img-fluid">
                  </div>
                  <div class="client_detail">
                    <h5>
                      Team 3
                    </h5>
                    <p>
                      CEO của trang web quản lý bưu điện của chúng tôi là một chuyên gia hàng đầu trong lĩnh vực công nghệ và logistics. Với tầm nhìn chiến lược và hơn 1 năm kinh nghiệm, vị lãnh đạo này đã dẫn dắt công ty dần trở thành một trong những nền tảng quản lý bưu phẩm hàng đầu Việt Nam.
                    </p>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        
        <div class="carousel-item">
          <div class="container">
            <div class="row">
              <div class="col-md-6">
                <div class="client_box c-b-1">
                  <div class="client_img">
                    <img src="images/client.png" alt="" class="img-fluid">
                  </div>
                  <div class="client_detail">
                    <h5>
                      Rock lu
                    </h5>
                    <p>
                      Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of
                      classical
                      Latin literature from 45 BC, making it over 2000 years
                    </p>
                  </div>
                </div>
              </div>
              <div class="col-md-6">
                <div class="client_box c-b-2">
                  <div class="client_img">
                    <img src="images/client.png" alt="" class="img-fluid">
                  </div>
                  <div class="client_detail">
                    <h5>
                      Rock lu
                    </h5>
                    <p>
                      Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of
                      classical
                      Latin literature from 45 BC, making it over 2000 years
                    </p>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="carousel-item">
          <div class="container">
            <div class="row">
              <div class="col-md-6">
                <div class="client_box c-b-1">
                  <div class="client_img">
                    <img src="images/client.png" alt="" class="img-fluid">
                  </div>
                  <div class="client_detail">
                    <h5>
                      Rock lu
                    </h5>
                    <p>
                      Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of
                      classical
                      Latin literature from 45 BC, making it over 2000 years
                    </p>
                  </div>
                </div>
              </div>
              <div class="col-md-6">
                <div class="client_box c-b-2">
                  <div class="client_img">
                    <img src="images/client.png" alt="" class="img-fluid">
                  </div>
                  <div class="client_detail">
                    <h5>
                      Rock lu
                    </h5>
                    <p>
                      Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of
                      classical
                      Latin literature from 45 BC, making it over 2000 years
                    </p>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>

    </div>

  </section>
  <!-- end testimonial section -->



  <!-- company section -->
  <section class="company_section layout_padding2">
    <div class="container">
      <div class="row">
        <div class="col-md-6">
          <div class="d-flex align-items-center h-100">
            <div class="company-detail">
              <h3>
                Company
              </h3>
              <p>
                Công ty chúng tôi tự hào cung cấp nền tảng quản lý bưu điện tiên tiến, giúp tối ưu hóa quy trình vận chuyển và giao nhận bưu phẩm. Với đội ngũ chuyên gia giàu kinh nghiệm và công nghệ hiện đại, chúng tôi cam kết mang lại dịch vụ uy tín và chất lượng hàng đầu cho khách hàng.
              </p>
            </div>
          </div>
        </div>
        <div class="col-md-6">
          <div class="company_img-box">
            <img src="images/company.jpg" alt="" class="img-fluid">
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- end company section -->



  <!-- contact section -->
  <section class="contact_section layout_padding">
    <div class="d-flex justify-content-center">
      <h2 class="heading_style">
        Contact us
      </h2>
    </div>
    <div class="container layout_padding2-top">
      <div class="row">
        <div class="col-md-6">
          <div id="map" class="h-100 w-100"></div>
        </div>

        <div class="col-md-6">
          <div class="contact_form-container">
            <form action="">
              <div>
                <input type="text" placeholder="Your Name">
              </div>
              <div>
                <input type="email" placeholder="Your Email">
              </div>
              <div>
                <input type="text" placeholder="Your Phone">
              </div>

              <div>
                <input type="text" class="message_input" placeholder="Message">
              </div>
              <div class="d-flex justify-content-end">
                <button type="submit " class="">
                  Send
                </button>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- end contact section -->



  <!-- info section -->
  <section class="info_section ">
    <div class="container ">
      <div class="row  mb-3 pb-4">
        <div class="col-md-3 info_logo">
          <div class="logo-box">
            <img src="images/logo-white.png" alt="">
            <span>
              Quản lí bưu điện
            </span>
          </div>
          <p>
            Niềm vui của bạn là hạnh phúc của chúng tôi
          </p>
          <div class="info_social">
            <div>
              <a href="">
                <img src="images/fb.png" alt="">
              </a>
            </div>
            <div>
              <a href="">
                <img src="images/twitter.png" alt="">
              </a>
            </div>
            <div>
              <a href="">
                <img src="images/g-plus.png" alt="">
              </a>
            </div>
            <div>
              <a href="">
                <img src="images/linkedin.png" alt="">
              </a>
            </div>
          </div>
        </div>
        <div class="col-md-3 info_address">
          <h5>
            Địa chỉ
          </h5>
          <p>
            285 Đội Cấn, Hà Nội, Việt Nam
          </p>
          <p>
            (+84) 123456789
          </p>
          <p>
            (+84) 123456789
          </p>
          <p>
            <a href="">
              quanlibuudien@gmail.com
            </a>
          </p>
        </div>
        <div class="col-md-3 info_links">

          <div class="info_nav ">
            <nav class="">
              <ul>
                <h5>
                  Links
                </h5>
                <li>
                  <a href="index.html"> Home</a>
                </li>
                <li>
                  <a href="about.html">About</a>
                </li>
                <li>
                  <a href="service.html"> Service</a>
                </li>
                <li>
                  <a href="shop.html"> Shop</a>
                </li>
                <li>
                  <a href="company.html"> Company</a>
                </li>
                <li>
                  <a href="contact.html">Contact us</a>
                </li>

              </ul>
            </nav>
          </div>
        </div>
        <div class="col-md-3 info_news">
          <h5>
            Newsletter
          </h5>
          <form action="">
            <div>
              <input type="text" placeholder="Your Name">
            </div>
            <div>
              <input type="email" placeholder="Email">
            </div>
            <div class="d-flex justify-content-end">
              <button type="submit">
                Subscribe
              </button>
            </div>
          </form>
        </div>
      </div>


    </div>
  </section>
  <!-- end info section -->

  <!-- footer section -->
  
</template>

<script>
export default {
    methods: {
        logout() {
            // Xử lý đăng xuất ở đây
            // Ví dụ: xóa token khỏi Local Storage và chuyển hướng đến trang đăng nhập
            localStorage.removeItem('token');
            this.$router.push('/login');
            window.location.reload();
        }
    }
};
</script>

<style scoped>
@import url("@/assets/css/responsive.css");
@import url("@/assets/css/bootstrap.css");
@import url("@/assets/css/style.css");
</style>
