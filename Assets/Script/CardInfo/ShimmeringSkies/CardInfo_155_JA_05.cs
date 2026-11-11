using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_155_JA_05 : CardInfo
{
    public CardInfo_155_JA_05()
    {
        this.cardNo = "155_JA_05";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ドナルドダック";
        this.cardName2 = "慧眼の警官";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LuigiAime;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
