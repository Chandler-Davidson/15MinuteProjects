import Html exposing (..)
import Html.Attributes exposing (..)
import Html.Events exposing (onInput)

main =
    Html.beginnerProgram 
    { model = model
    , view = view
    , update = update 
    }


-- Model
type alias Model = 
    { name: String
    , password : String
    , passwordAgain : String
    , age : String
    }

model : Model
model = 
    Model "" "" "" ""


-- Update
type Msg
    = Name String
    | Password String
    | PasswordAgain String
    | Age String

update : Msg -> Model -> Model
update msg model =
    case msg of
        Name name -> 
            { model | name = name }
        Password password ->
            { model | password = password }
        PasswordAgain password ->
            { model | passwordAgain = password }
        Age age ->
            { model | age = age }


-- View
view : Model -> Html Msg
view model =
    div []
    [ input [ type_ "text", placeholder "Name", onInput Name ] []
    , input [ type_ "password", placeholder "Password", onInput Password ] []
    , input [ type_ "password", placeholder "Re-enter Password", onInput PasswordAgain ] []
    , input [ type_  "number", placeholder "21", onInput Age ] []
    , viewValidation model
    ]

viewValidation : Model -> Html msg
viewValidation model =
    if changesMade model then
        let
            (color, message) =
                if not (passwordsMatch model) then
                    ("red", "Passwords do not match!")
                else if not (passwordLength model 8) then
                    ("red", "Password not long enough!")
                else if getAge model < 20 then
                    ("red", "You're too young!")
                else
                    ("green", "OK")
        in
            div [ style [("color", color)] ] [ text message ]
    else
        div [][]


passwordsMatch : Model -> Bool
passwordsMatch model =
    model.password == model.passwordAgain 

passwordLength : Model -> Int -> Bool
passwordLength model length =
    String.length model.password >= length

changesMade : Model -> Bool
changesMade model =
    String.length model.password > 0

getAge : Model -> Int
getAge model =
    String.toInt model.age
    |> Result.toMaybe
    |> Maybe.withDefault 0



