using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_139_JA_06 : CardInfo
{
    public CardInfo_139_JA_06()
    {
        this.cardNo = "139_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ガジェット・ハックレンチ";
        this.cardName2 = "創造的発想家";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AndreaFemerstrand;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
