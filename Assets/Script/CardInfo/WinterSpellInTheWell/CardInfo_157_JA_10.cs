using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_157_JA_10 : CardInfo
{
    public CardInfo_157_JA_10()
    {
        this.cardNo = "157_JA_10";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "プルート";
        this.cardName2 = "手がかり探知犬";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LizRichards;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
