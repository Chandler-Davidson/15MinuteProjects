import Html exposing (..)
import Html.Events exposing (..)
import Random
import List

main =
    Html.program
    { init = init
    , view = view
    , update = update
    , subscriptions = \_ -> Sub.none
    }

-- Model
type alias Model =
    { dice : List Int
    }

type alias DieFace =
    { dieFace : Int
    }

init : (Model, Cmd Msg)
init = 
    (Model [ 1 ], Cmd.none)


-- Update
type Msg 
    = Roll
    | NewFace Int
    | NewDie


update : Msg -> Model -> (Model, Cmd Msg)
update msg model =
    case msg of
        Roll ->
            (model, rollDice model)
        NewFace newFace ->
            (Model model.dice, Cmd.none)
        --NewDie ->
        --    (model, addDie model)

rollDice : Model -> Cmd Msg
rollDice model =
    List.repeat (List.length model) 3


-- View
view : Model -> Html Msg
view model =
    div []
    [ map (\x -> createDie x)
    , button [ onClick Roll ] [ text "Roll" ]
    , button [ onClick NewDie ] [ text "Add Die" ]
    ]

createDie : DieFace -> Html Msg
createDie dieFace =
    [ h1 [] text (toString dieFace) ]





