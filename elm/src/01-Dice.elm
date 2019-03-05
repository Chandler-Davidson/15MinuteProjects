import Browser
import Html exposing (..)
import Html.Events exposing (..)
import Random
import List exposing (..)

-- MAIN
main =
  Browser.element
  { init = init
  , update = update
  , subscriptions = subscriptions
  , view = view
  }

-- MODEL
type alias Model =
  { dice : List Int
  }

init : () -> (Model, Cmd Msg)
init _ =
  ( Model [1]
  , Cmd.none
  )

-- UPDATE
type Msg
  = Roll
  | NewFaces (List Int)
  | AddDie

update : Msg -> Model -> ( Model, Cmd Msg )
update msg model =
    case msg of
        Roll ->
          ( model
          , Random.generate NewFaces (Random.list (List.length model.dice) (Random.int 1 6))
          )

        NewFaces newFaces ->
          ( Model newFaces
          , Cmd.none
          )

        AddDie ->
          ( {model | dice = 1 :: model.dice}
          , Cmd.none
          )
            
-- SUBSCRIPTIONS
subscriptions : Model -> Sub Msg
subscriptions model =
  Sub.none

-- VIEW
view : Model -> Html Msg
view model =
  div []
    [ ul [] (List.map (\x -> li [] [text (String.fromInt x)]) model.dice)
    , button [ onClick Roll ] [ text "Roll" ]
    , button [ onClick AddDie] [ text "Add Die" ]
    ]