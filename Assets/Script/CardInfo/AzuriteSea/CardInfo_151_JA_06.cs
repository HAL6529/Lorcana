using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_151_JA_06 : CardInfo
{
    public CardInfo_151_JA_06()
    {
        this.cardNo = "151_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ガジェット・ハックレンチ";
        this.cardName2 = "するどいネズミ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SamantaErdini;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
