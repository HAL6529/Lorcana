using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_154_JA_10 : CardInfo
{
    public CardInfo_154_JA_10()
    {
        this.cardNo = "154_JA_10";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "デイジーダック";
        this.cardName2 = "超常現象調査官";
        this.power = 4;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4, EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
