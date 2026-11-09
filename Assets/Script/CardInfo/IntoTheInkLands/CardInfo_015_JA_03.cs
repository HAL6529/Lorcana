using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_015_JA_03 : CardInfo
{
    public CardInfo_015_JA_03()
    {
        this.cardNo = "015_JA_03";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "パディータ";
        this.cardName2 = "献身の母犬";
        this.power = 1;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DefneTozumAndLivioCacciatore;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
