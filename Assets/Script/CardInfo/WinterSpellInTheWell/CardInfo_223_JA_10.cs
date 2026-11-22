using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_223_JA_10 : CardInfo
{
    public CardInfo_223_JA_10()
    {
        this.cardNo = "223_JA_10";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "グーフィー";
        this.cardName2 = "ドタバタ迷探偵";
        this.power = 5;
        this.toughness = 7;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
