using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_113_JA_08 : CardInfo
{
    public CardInfo_113_JA_08()
    {
        this.cardNo = "113_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アルキメデス";
        this.cardName2 = "引き出しの多いフクロウ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.Gwawi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
