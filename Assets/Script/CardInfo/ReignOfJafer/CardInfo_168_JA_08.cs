using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_168_JA_08 : CardInfo
{
    public CardInfo_168_JA_08()
    {
        this.cardNo = "168_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "アーサー";
        this.cardName2 = "決意の従騎士";
        this.power = 6;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.EduFrancisco;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
