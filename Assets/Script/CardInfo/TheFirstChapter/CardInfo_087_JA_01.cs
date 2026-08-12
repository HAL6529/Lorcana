using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_087_JA_01 : CardInfo
{
    public CardInfo_087_JA_01()
    {
        this.cardNo = "087_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉÅÉO";
        this.cardName2 = "ëÄÇËÇÃéÖ";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = "Aubrey Archer";
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
