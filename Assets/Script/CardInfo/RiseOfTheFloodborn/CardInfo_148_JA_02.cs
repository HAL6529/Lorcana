using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_148_JA_02 : CardInfo
{
    public CardInfo_148_JA_02()
    {
        this.cardNo = "148_JA_02";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ÉpÉrÅ[";
        this.cardName2 = "å´ñæÇ»ÇÈç≈í∑òV";
        this.power = 3;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
