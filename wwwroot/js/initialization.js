function createProduct() {
    if (localStorage.getItem('game') == null) {
        let products = [{
            id: 1,
            status: 1, 
            title: 'Black Myth: Wukong',
            img: './assets/img/file_img_game/Black_Myth_Wukong.png',
            category: 'Game Triple A',
            price: 1299000,
            desc: 'Black Myth: Wukong là một trò chơi video nhập vai hành động đang được phát triển bởi công ty Trung Quốc Game Science. Được lấy cảm hứng từ tiểu thuyết cổ điển "Tây du ký", trò chơi xoay quanh nhân vật Tôn Ngọc Hoáng (Sun Wukong), một con khỉ có sức mạnh phi thường và khả năng biến hóa.'
        },
        {
            id: 2,
            status: 1, 
            title: 'Black Myth: Wukong',
            img: './assets/img/file_img_game/Black_Myth_Wukong.png',
            category: 'Game Triple A',
            price: 180000,
            desc: 'Black Myth: Wukong là một trò chơi video nhập vai hành động đang được phát triển bởi công ty Trung Quốc Game Science. Được lấy cảm hứng từ tiểu thuyết cổ điển "Tây du ký", trò chơi xoay quanh nhân vật Tôn Ngọc Hoáng (Sun Wukong), một con khỉ có sức mạnh phi thường và khả năng biến hóa.'
        },
        {
            id: 3,
            status: 1, 
            title: 'Black Myth: Wukong',
            img: './assets/img/file_img_game/Black_Myth_Wukong.png',
            category: 'Game Triple A',
            price: 130000,
            desc: 'Black Myth: Wukong là một trò chơi video nhập vai hành động đang được phát triển bởi công ty Trung Quốc Game Science. Được lấy cảm hứng từ tiểu thuyết cổ điển "Tây du ký", trò chơi xoay quanh nhân vật Tôn Ngọc Hoáng (Sun Wukong), một con khỉ có sức mạnh phi thường và khả năng biến hóa.'
        },
        {
            id: 4,
            status: 1, 
            title: 'Black Myth: Wukong',
            img: './assets/img/file_img_game/Black_Myth_Wukong.png',
            category: 'Game Triple A',
            price: 2000000,
            desc: 'Black Myth: Wukong là một trò chơi video nhập vai hành động đang được phát triển bởi công ty Trung Quốc Game Science. Được lấy cảm hứng từ tiểu thuyết cổ điển "Tây du ký", trò chơi xoay quanh nhân vật Tôn Ngọc Hoáng (Sun Wukong), một con khỉ có sức mạnh phi thường và khả năng biến hóa.'
        }
        
        ]
        localStorage.setItem('products', JSON.stringify(products));
    }
}

function createAdminAccount() {
    let accounts = localStorage.getItem("accounts");
    if (!accounts) {
        accounts = [];
        accounts.push({
            fullname: "Đinh Hữu Phúc",
            phone: "Dinh-Huu-Phuc",
            password: "123456",
            address: 'https://github.com/DINH-HUU-PHUC',
            email: 'Phucgp74@gmail.com',
            status: 1,
            join: new Date(),
            cart: [],
            userType: 1
        })
        accounts.push({
            fullname: "Đinh Hữu Phúc",
            phone: "0398743229",
            password: "DinhHuuPhucHoang",
            address: '',
            email: '',
            status: 1,
            join: new Date(),
            cart: [],
            userType: 1
        })
        localStorage.setItem('accounts', JSON.stringify(accounts));
    }
}

window.onload = createProduct();
window.onload = createAdminAccount();