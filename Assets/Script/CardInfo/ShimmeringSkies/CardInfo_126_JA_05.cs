using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_126_JA_05 : CardInfo
{
    public CardInfo_126_JA_05()
    {
        this.cardNo = "126_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "華麗なるダンサー";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RaquelVillanueva;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
