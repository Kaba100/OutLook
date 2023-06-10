using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using OutLook.Model;
using System.Windows.Input;

namespace OutLook.ViewModel;

public partial class FleshVM : ObservableObject
{
    
    [ObservableProperty]
    
    public ObservableCollection<Flesh> fleshCollect;


    [ObservableProperty]
    public ObservableCollection<Recipe> recipeCollect;

    [ObservableProperty]
    public ObservableCollection<Ingredient> ingredientcollect;

    public FleshVM()
	{
                

        fleshCollect = new ObservableCollection<Flesh>();
        Flesh A1 = new Flesh();
        A1.Name = "Chicken";
        A1.Picture = "dotnet_bot.svg";
        A1.Color = Color.FromRgb(229, 251, 243);
        fleshCollect.Add(A1);

        Flesh B1 = new Flesh();
        B1.Name = "Beef";
        B1.Picture = "woman.PNG";
        B1.Color = Color.FromRgb(247, 250, 231);
        fleshCollect.Add(B1);

        Flesh C1 = new Flesh();
        C1.Name = "Fish";
        C1.Picture = "woman.PNG";
        C1.Color = Color.FromRgb(233, 229, 249);
        fleshCollect.Add(C1);

        Flesh D1 = new Flesh();
        D1.Name = "Bakery";
        D1.Picture = "woman.PNG";
        D1.Color = Color.FromRgb(251, 229, 236);
        fleshCollect.Add(D1);

        Flesh E1 = new Flesh();
        E1.Name = "Pork";
        E1.Picture = "woman.PNG";
        E1.Color = Color.FromRgb(251,229,236);
        fleshCollect.Add(E1);

        Flesh F1 = new Flesh();
        F1.Name = "Mutton";
        F1.Picture = "woman.PNG";
        F1.Color = Color.FromRgb(66, 194, 167);
        fleshCollect.Add(F1);

       
        recipeCollect = new ObservableCollection<Recipe>();
        Recipe A = new Recipe();
        A.Name = "Chinese Vegetables";
        A.Pictures = "woman.PNG";
        A.Time = "5 lessons 13h 12m";
        A.Color = Color.FromRgb(66, 194, 167);
        recipeCollect.Add(A);

        Recipe B = new Recipe();
        B.Name = "Chilli Chicken";
        B.Pictures = "woman.PNG";
        B.Time = "3 lessons 12h 2m";
        B.Color = Color.FromRgb(255, 206, 93);
        recipeCollect.Add(B);

        Recipe C = new Recipe();
        C.Name = "Marion Grasby";
        C.Pictures = "woman.PNG";
        C.Time = "2 lessons 15h 10m";
        C.Color = Color.FromRgb(0, 158, 220);
        recipeCollect.Add(C);

        Recipe D = new Recipe();
        D.Name = "Caramelised Chicken";
        D.Pictures = "woman.PNG";
        D.Time = "19 lessons 20h 14m";
        D.Color = Color.FromRgb(254, 210, 72);
        recipeCollect.Add(D);

        Recipe E = new Recipe();
        E.Name = "Curried Sausages";
        E.Pictures = "woman.PNG";
        E.Time = "10 lessons 5h 35m";
        E.Color = Color.FromRgb(222, 204, 90);
        recipeCollect.Add(E);

        Recipe F = new Recipe();
        F.Name = "Creamy broccoli"; 
        F.Pictures = "woman.PNG";
        F.Time = "8 lessons 16h 20m";
        F.Color = Color.FromRgb(229, 251, 243);
        recipeCollect.Add(F);

        Recipe G = new Recipe();
        G.Name = "Cheesy Nacho";
        G.Pictures = "woman.PNG";
        G.Color = Color.FromRgb(246, 85, 88);
        recipeCollect.Add(G);

        Recipe H = new Recipe();
        H.Name = "Little Anzac";
        H.Pictures = "woman.PNG";
        H.Color = Color.FromRgb(235, 195, 190);
        recipeCollect.Add(H);

        Recipe I = new Recipe();
        I.Name = "Potatoes Lorraine";
        I.Pictures = "woman.PNG";
        I.Color = Color.FromRgb(203, 203, 203);
        recipeCollect.Add(I);

        Recipe J = new Recipe();
        J.Name = "Mini Chicken";
        J.Pictures = "woman.PNG";
        J.Color = Color.FromRgb(254, 115, 135);
        recipeCollect.Add(J);

        Recipe K = new Recipe();
        K.Name = "Samurai Chicken";
        K.Pictures = "woman.PNG";
        K.Color = Color.FromRgb(225, 97, 231);
        recipeCollect.Add(K);

        Recipe L = new Recipe();
        L.Name = "Haloumi Zucchini";
        L.Pictures = "woman.PNG";
        L.Color = Color.FromRgb(25, 297, 231);
        recipeCollect.Add(L);

        Recipe M = new Recipe();
        M.Name = "Fried Rice";
        M.Pictures = "woman.PNG";
        M.Color = Color.FromRgb(125, 207, 31);
        recipeCollect.Add(M);

        Recipe N = new Recipe();
        N.Name = "Mars Bar";
        N.Pictures = "woman.PNG";
        N.Color = Color.FromRgb(229, 220, 201);
        recipeCollect.Add(N);

        Recipe O = new Recipe();
        O.Name = "Okele Guinea";
        O.Pictures = "woman.PNG";
        O.Color = Color.FromRgb(5, 297, 231);
        recipeCollect.Add(O);

        Recipe P = new Recipe();
        P.Name = "Haloumi Karaage";
        P.Pictures = "woman.PNG";
        P.Color = Color.FromRgb(95, 297, 241);
        recipeCollect.Add(P);

        Recipe Q = new Recipe();
        Q.Name = "Biang biang crispy";
        Q.Pictures = "woman.PNG";
        Q.Color = Color.FromRgb(425, 297, 531);
        recipeCollect.Add(Q);

        Recipe R = new Recipe();
        R.Name = "Barbecue Sweet Potatoes";
        R.Pictures = "woman.PNG";
        R.Color = Color.FromRgb(2, 207, 201);
        recipeCollect.Add(R);

        Recipe S = new Recipe();
        S.Name = "Cheesy tacco";
        S.Pictures = "woman.PNG";
        S.Color = Color.FromRgb(325, 288, 244);
        recipeCollect.Add(S);

        Recipe T = new Recipe();
        T.Name = "Lemon Wathaway Cake";
        T.Pictures = "woman.PNG";
        T.Color = Color.FromRgb(279, 222, 131);
        recipeCollect.Add(T);

        // Recipes U = new Recipes();
        // U.Name = "Miniham";
        // U.Pictures = "woman.PNG";
        //U.Color = Color.FromRgb(225, 297, 231);

        ingredientcollect = new ObservableCollection<Ingredient>();
        Ingredient a = new Ingredient();
        a.Name = "Chopped Potato";
        a.Picture = "chicken.jpg";
        a.Color = Color.FromRgb(255,255,255);
        ingredientcollect.Add(a);

        Ingredient b = new Ingredient();
        b.Name = "500Gm chicken";
        b.Picture = "chicken.jpg";
        b.Color = Color.FromRgb(255, 255, 255);
        ingredientcollect.Add(b);

        Ingredient c = new Ingredient();
        c.Name = "Baby Tomato";
        c.Picture = "chicken.jpg";
        c.Color = Color.FromRgb(255, 255, 255);
        ingredientcollect.Add(c);

        Ingredient d = new Ingredient();
        d.Name = "Fresh parsley";
        d.Picture = "chicken.jpg";
        d.Color = Color.FromRgb(255, 255, 255);
        ingredientcollect.Add(d);

        Ingredient e = new Ingredient();
        e.Name = "Ginger";
        e.Picture = "chicken.jpg";
        e.Color = Color.FromRgb(255, 255, 255);
        ingredientcollect.Add(e);






    }

    public ICommand SelectedItemCommand => new Command<Recipe>(async (recipes) => 
    {
        await Shell.Current.GoToAsync($"MealsPage?FoodNameProp={recipes.Name}");
    });


}