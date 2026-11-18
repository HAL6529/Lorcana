using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_062_JA_08 : CardInfo
{
    public CardInfo_062_JA_08()
    {
        this.cardNo = "062_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ジミニー・クリケット";
        this.cardName2 = "冷静沈着";
        this.power = 1;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RosaLaBarberaAndLivioCacciatore;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Pinocchio;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
