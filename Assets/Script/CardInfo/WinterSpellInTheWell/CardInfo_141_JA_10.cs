using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_141_JA_10 : CardInfo
{
    public CardInfo_141_JA_10()
    {
        this.cardNo = "141_JA_10";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "デイジーダック";
        this.cardName2 = "お化け探知屋";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlanBatson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
