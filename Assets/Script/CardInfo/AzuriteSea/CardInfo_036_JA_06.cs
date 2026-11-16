using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_036_JA_06 : CardInfo
{
    public CardInfo_036_JA_06()
    {
        this.cardNo = "036_JA_06";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ÉnÉfÉX";
        this.cardName2 = "éÄé“ÇÃçëÇÃâ§Ç≈Ç∑Ç«Ç§Ç‡";
        this.power = 3;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.DennyMinonne;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
