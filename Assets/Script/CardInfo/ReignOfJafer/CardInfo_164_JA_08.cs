using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_164_JA_08 : CardInfo
{
    public CardInfo_164_JA_08()
    {
        this.cardNo = "164_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "アデレード・ボンファミーユ";
        this.cardName2 = "芸術の後援者";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LisanneKoeteeuw;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
