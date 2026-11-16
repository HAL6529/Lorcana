using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_172_JA_06 : CardInfo
{
    public CardInfo_172_JA_06()
    {
        this.cardNo = "172_JA_06";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ƒJƒJƒ‚ƒ‰";
        this.cardName2 = "ŠC‘¯‚Ì‘°’·";
        this.power = 4;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
