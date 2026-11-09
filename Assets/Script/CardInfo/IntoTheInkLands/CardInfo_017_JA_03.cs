using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_017_JA_03 : CardInfo
{
    public CardInfo_017_JA_03()
    {
        this.cardNo = "017_JA_03";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "プルート";
        this.cardName2 = "万全の番犬";
        this.power = 3;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DaveAlvarezAndAlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift5, EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
