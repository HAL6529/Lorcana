using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_118_JA_13 : CardInfo
{
    public CardInfo_118_JA_13()
    {
        this.cardNo = "118_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "パチャ";
        this.cardName2 = "気苦労の多いお客さん";
        this.power = 2;
        this.toughness = 6;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.HaJungSong;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Reckless };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
