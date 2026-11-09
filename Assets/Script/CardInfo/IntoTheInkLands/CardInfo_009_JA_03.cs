using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_009_JA_03 : CardInfo
{
    public CardInfo_009_JA_03()
    {
        this.cardNo = "009_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "ミュージックアーティスト";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ErikaWiseman;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Singer3 };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
