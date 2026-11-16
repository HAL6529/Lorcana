using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_215_JA_06 : CardInfo
{
    public CardInfo_215_JA_06()
    {
        this.cardNo = "215_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ティガー";
        this.cardName2 = "見張り台のオレ様";
        this.power = 0;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MikeParker;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Tigger, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
