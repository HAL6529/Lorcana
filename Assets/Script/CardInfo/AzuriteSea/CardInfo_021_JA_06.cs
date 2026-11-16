using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_021_JA_06 : CardInfo
{
    public CardInfo_021_JA_06()
    {
        this.cardNo = "021_JA_06";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ÉJÉìÉK";
        this.cardName2 = "à§èÓê[Ç¢ïÍ";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GianlucaBarone;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
