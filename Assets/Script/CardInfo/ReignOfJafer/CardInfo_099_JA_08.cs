using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_099_JA_08 : CardInfo
{
    public CardInfo_099_JA_08()
    {
        this.cardNo = "099_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ガジェット・ハックレンチ";
        this.cardName2 = "型破りな科学者";
        this.power = 3;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LisanneKoeteeuw;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
