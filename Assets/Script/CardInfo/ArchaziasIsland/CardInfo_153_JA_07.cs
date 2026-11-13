using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_153_JA_07 : CardInfo
{
    public CardInfo_153_JA_07()
    {
        this.cardNo = "153_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒNƒ‰ƒ‰ƒxƒ‹";
        this.cardName2 = "•ñ“¹“Á”hˆõ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.StefanoSpagnuolo;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
