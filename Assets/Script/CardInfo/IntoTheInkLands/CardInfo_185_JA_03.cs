using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_185_JA_03 : CardInfo
{
    public CardInfo_185_JA_03()
    {
        this.cardNo = "185_JA_03";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ムファサ";
        this.cardName2 = "プライドランドの英雄";
        this.power = 3;
        this.toughness = 10;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.EvanaKisaAndLivioCacciatore;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.King};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
